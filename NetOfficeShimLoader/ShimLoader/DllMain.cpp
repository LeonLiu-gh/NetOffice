#include "stdafx.h"
#include <map>
#include "ShimProxyFactory.h"
#include "DllRegister32.h"
#include "DllRegister64.h"
#include "DllRegister32On64.h"
#include "ShimArguments.h"
#include "Vars.hpp"

HANDLE						_thread				= NULL;		// DLL module create thread
HINSTANCE					_module				= NULL;		// DLL module handle
ULONG						_components			= 0;		// Count of open instances
ULONG						_locks				= 0;		// Count of server locks
BOOL						_unloadAllowed		= TRUE;		// determines unload is ok
std::map<LPCWSTR, ULONG>	_componentsMap;					// Identifies open instances in Debug Build

bool Is64BitWindows(bool & isWindows64bit);
HRESULT InitializeMain(HMODULE hModule, DWORD  ul_reason_for_call, LPVOID lpReserved);
void CleanupMain();

BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved)
{
	HRESULT hr = S_OK;
	try
	{
		switch (ul_reason_for_call)
		{
		case DLL_PROCESS_ATTACH:
		{
			hr = InitializeMain(hModule, ul_reason_for_call, lpReserved);
			break;
		}
		case DLL_PROCESS_DETACH:
		{
			CleanupMain();
			break;
		}
		}
	}
	catch (...)
	{
		ShimDebugMessageBox(L"Unexpected Exception", L"DllMain");
	}

#ifdef DEBUG

	if (FAILED(hr))
	{
		ShimDebugMessageBox(L"Unexpected Result", L"DllMain");
	}

#endif

	return S_OK == hr;
}

STDAPI DllCanUnloadNow()
{
	HRESULT hr = (_components == 0 && _locks == 0) ? S_OK : E_UNEXPECTED;

	if(FAILED(hr))
		NetOffice_ShimLoader_Analytics::WriteError(L"DllMain::DllCanUnloadNow::Unexpected %ld components left.", _components);

#ifdef DEBUG

	// this is a check to avoid heap leaks
	// every class in ShimLoader increment a static counter(_components) in ctor and decrement them in dtor
	// if this global counter is not 0 before the dll is forced to unload means the ShimLoader is kind of a spit.
	// _unloadAllowed is because the host application check for unload in Idle time
	// TODO: create a common base class to increment/decrement this counter and let all classes in ShimLoader inherit from
	if (!SUCCEEDED(hr) && _unloadAllowed)
	{
		WCHAR szBuffer[128];
		wsprintf(szBuffer, L"Unexpected: %ld components left.", _components);
		ShimDebugMessageBox(szBuffer, L"DllCanUnloadNow");
	}

#endif

	return hr;
}

STDAPI DllGetClassObject(REFCLSID rclsid, REFIID riid, void** ppv)
{
	HRESULT hr = S_OK;
	ShimProxyFactory* pCF = nullptr;
	*ppv = NULL;

	CLSID clsId;
	hr = CLSIDFromString(ShimProxy_CLSID, &clsId);

	if(SUCCEEDED(hr) && rclsid != clsId)
	{
		hr = CLASS_E_CLASSNOTAVAILABLE;
	}

	if (SUCCEEDED(hr))
	{
		pCF = new (std::nothrow) ShimProxyFactory();
		if (SUCCEEDED(hr) && NULL == pCF)
		{
			hr = E_OUTOFMEMORY;
		}
	}

	if (SUCCEEDED(hr))
	{
		hr = pCF->QueryInterface(riid, ppv);
		if (FAILED(hr))
		{
			*ppv = NULL;
			delete pCF;
			pCF = nullptr;
		}
	}

	return hr;
}

STDAPI DllRegisterServer()
{
	HRESULT hr = S_OK;
	NetOffice_ShimLoader_Analytics::InitializeWriteRegisterLog();
	NetOffice_ShimLoader_Analytics::WriteRegisterLog(L"DllMain::DllRegisterServer::Enter");

	if (SUCCEEDED(hr) && ENABLE_SELF_REGISTRATION)
	{
		try
		{
#if X64BUILD

			//hr = NetOffice_ShimLoader_Register64::DllRegister(
			//	_module,
			//	ShimProxy_Host_Application,
			//	ShimProxy_LoadBehavior,
			//	ShimProxy_CommandLineSafe,
			//	ShimProxy_ProgID,
			//	ShimProxy_CLSID_Text,
			//	ShimProxy_FriendlyName,
			//	ShimProxy_Description,
			//	ShimProxy_Version,
			//	static_cast<RegisterMode>(SELF_REGISTER_MODE));

#else

			bool is64BitWindows = false;
			if (Is64BitWindows(is64BitWindows))
			{
				if (is64BitWindows)
				{
					IfFailGo(NetOffice_ShimLoader_Register32On64::DllRegister(
						_module,
						ShimProxy_Host_Application,
						ShimProxy_LoadBehavior,
						ShimProxy_CommandLineSafe,
						ShimProxy_ProgID,
						ShimProxy_CLSID,
						ShimProxy_FriendlyName,
						ShimProxy_Description,
						ShimProxy_Version,
						static_cast<RegisterMode>(SELF_REGISTER_MODE),
						ENABLE_ADDIN_REGISTRATION));
				}
				else
				{
					/*hr = NetOffice_ShimLoader_Register32::DllRegister(
					_module,
					ShimProxy_Host_Application,
					ShimProxy_LoadBehavior,
					ShimProxy_CommandLineSafe,
					ShimProxy_ProgID,
					ShimProxy_CLSID_Text,
					ShimProxy_FriendlyName,
					ShimProxy_Description,
					ShimProxy_Version,
					static_cast<RegisterMode>(SELF_REGISTER_MODE));*/
				}
			}
			else
			{
				hr = E_UNEXPECTED;
				IfFailGo(hr);
			}

#endif
		}
		catch (...)
		{
			NetOffice_ShimLoader_Analytics::WriteRegisterError(L"DllMain::DllRegisterServer::Exception");
			hr = E_FAIL;
			IfFailGo(hr);
		}
	}

	NetOffice_ShimLoader_Analytics::WriteRegisterLog(L"DllMain::DllRegisterServer::Exit");
	return hr;

Error:

	NetOffice_ShimLoader_Analytics::WriteRegisterError(L"DllMain::DllRegisterServer::FailExit", hr);
	return hr;
}

STDAPI DllUnregisterServer()
{
	HRESULT hr = S_OK;
	NetOffice_ShimLoader_Analytics::InitializeUnRegisterLog();
	NetOffice_ShimLoader_Analytics::WriteUnRegisterLog(L"DllMain::DllUnregisterServer::Enter");

	if (ENABLE_SELF_REGISTRATION)
	{
		try
		{
#if X64BUILD

			//hr = NetOffice_ShimLoader_Register64::DllUnregister(
			//	ShimProxy_Host_Application,
			//	ShimProxy_ProgID,
			//	ShimProxy_CLSID_Text,
			//	ShimProxy_Version,
			//	static_cast<RegisterMode>(SELF_REGISTER_MODE));

#else

			bool is64BitWindows = false;
			if (Is64BitWindows(is64BitWindows))
			{
				if (is64BitWindows)
				{
					IfFailGo(NetOffice_ShimLoader_Register32On64::DllUnregister(
						ShimProxy_Host_Application,
						ShimProxy_ProgID,
						ShimProxy_CLSID,
						ShimProxy_Version,
						static_cast<RegisterMode>(SELF_REGISTER_MODE),
						ENABLE_ADDIN_REGISTRATION));
				}
				else
				{
					//hr = NetOffice_ShimLoader_Register32::DllUnregister(
					//	ShimProxy_Host_Application,
					//	ShimProxy_ProgID,
					//	ShimProxy_CLSID_Text,
					//	ShimProxy_Version,
					//	static_cast<RegisterMode>(SELF_REGISTER_MODE));
				}

			}
			else
			{
				hr = E_UNEXPECTED;
				IfFailGo(hr);
			}

#endif
		}
		catch (...)
		{
			NetOffice_ShimLoader_Analytics::WriteUnRegisterError(L"DllMain::DllUnregisterServer::Exception");
			hr = E_FAIL;
			IfFailGo(hr);
		}
	}

	NetOffice_ShimLoader_Analytics::WriteUnRegisterLog(L"DllMain::DllUnregisterServer::Exit");
	return hr;

Error:

	NetOffice_ShimLoader_Analytics::WriteRegisterError(L"DllMain::DllUnregisterServer::FailExit", hr);
	return hr;
}

HRESULT InitializeMain(HMODULE hModule, DWORD  ul_reason_for_call, LPVOID lpReserved)
{
	HRESULT hr = S_OK;

	LogFile_Path = new WCHAR[MAX_PATH + 1];
	LogFile_Register_Path = new WCHAR[MAX_PATH + 1];
	LogFile_UnRegister_Path = new WCHAR[MAX_PATH + 1];

	hr = NetOffice_ShimLoader_Analytics::InitializeLog();

#ifdef DEBUG

	if (FAILED(hr))
	{
		ShimDebugMessageBox(L"Failed to initialize log.", L"");
		return hr;
	}

#endif

	NetOffice_ShimLoader_Analytics::WriteLogTimeStamp(L"DllMain::Initialize::Enter");

	_module = hModule;
	_thread = GetCurrentThread();
	::DisableThreadLibraryCalls(hModule);

	TargetManagedAggregator_Folder = new WCHAR[MAX_PATH + 1];
	TargetManagedAggregator_AssemblyName = new WCHAR[MAX_PATH + 1];
	TargetManagedAggregator_ClassName = new WCHAR[MAX_PATH + 1];
	TargetManagedAggregator_AppDomain_FriendlyName = new WCHAR[MAX_PATH + 1];
	TargetManagedAggregator_AppDomain_BaseFolder = new WCHAR[MAX_PATH + 1];

	Target_AssemblyName = new WCHAR[MAX_PATH + 1];
	Target_AssemblyFileName = new WCHAR[MAX_PATH + 1];
	Target_ConnectClassName = new WCHAR[MAX_PATH + 1];
	Target_ConfigFileName = new WCHAR[MAX_PATH + 1];

	ShimProxy_CLSID = new WCHAR[MAX_PATH + 1];
	ShimProxy_ProgID = new WCHAR[MAX_PATH + 1];
	ShimProxy_Version = new WCHAR[MAX_PATH + 1];
	lstrcpyn(ShimProxy_Version, L"1.0", MAX_PATH + 1);
	ShimProxy_FriendlyName = new WCHAR[MAX_PATH + 1];
	ShimProxy_Description = new WCHAR[MAX_PATH + 1];

	UpdateManagedAggregator_Folder = new WCHAR[MAX_PATH + 1];
	UpdateManagedAggregator_AssemblyName = new WCHAR[MAX_PATH + 1];
	UpdateManagedAggregator_ClassName = new WCHAR[MAX_PATH + 1];
	UpdateManagedAggregator_AppDomain_FriendlyName = new WCHAR[MAX_PATH + 1];
	UpdateManagedAggregator_AppDomain_BaseFolder = new WCHAR[MAX_PATH + 1];

	Update_AssemblyName = new WCHAR[MAX_PATH + 1];
	Update_AssemblyFileName = new WCHAR[MAX_PATH + 1];
	Update_ConnectClassName = new WCHAR[MAX_PATH + 1];
	Update_ConfigFileName = new WCHAR[MAX_PATH + 1];

	ShimArguments* args = new (std::nothrow) ShimArguments();
	if (!args)
	{
		hr = E_OUTOFMEMORY;
	}

	if (args)
	{
		hr = args->Load();
		if (SUCCEEDED(hr))
		{
			hr = args->Read();
		}
	}

	if (args)
	{
		delete args;
		args = nullptr;
	}

	if(SUCCEEDED(hr))
		NetOffice_ShimLoader_Analytics::WriteLog(L"DllMain::Initialize::Exit");
	else
		NetOffice_ShimLoader_Analytics::WriteError(L"DllMain::Initialize::FailExit", hr);

	return hr;
}

void CleanupMain()
{
	NetOffice_ShimLoader_Analytics::WriteLog(L"DllMain::Cleanup::Enter");

	if (Custom_Register_Values)
	{
		size_t arraySize = (sizeof(Custom_Register_Values) / sizeof(*Custom_Register_Values));
		for (size_t i = 0; i < arraySize; i++)
		{
			delete Custom_Register_Values[i];
		}
		delete[] Custom_Register_Values;
		Custom_Register_Values = nullptr;
	}
	if (ShimProxy_Host_Application)
	{
		delete[] ShimProxy_Host_Application;
		ShimProxy_Host_Application = nullptr;
	}


	if (UpdateManagedAggregator_AppDomain_BaseFolder)
	{
		delete[] UpdateManagedAggregator_AppDomain_BaseFolder;
		UpdateManagedAggregator_AppDomain_BaseFolder = nullptr;
	}

	if (UpdateManagedAggregator_AppDomain_FriendlyName)
	{
		delete[] UpdateManagedAggregator_AppDomain_FriendlyName;
		UpdateManagedAggregator_AppDomain_FriendlyName = nullptr;
	}

	if (UpdateManagedAggregator_ClassName)
	{
		delete[] UpdateManagedAggregator_ClassName;
		UpdateManagedAggregator_ClassName = nullptr;
	}

	if (UpdateManagedAggregator_AssemblyName)
	{
		delete[] UpdateManagedAggregator_AssemblyName;
		UpdateManagedAggregator_AssemblyName = nullptr;
	}

	if (UpdateManagedAggregator_Folder)
	{
		delete[] UpdateManagedAggregator_Folder;
		UpdateManagedAggregator_Folder = nullptr;
	}

	if (Update_ConfigFileName)
	{
		delete[] Update_ConfigFileName;
		Update_ConfigFileName = nullptr;
	}
	if (Update_ConnectClassName)
	{
		delete[] Update_ConnectClassName;
		Update_ConnectClassName = nullptr;
	}
	if (Update_AssemblyFileName)
	{
		delete[] Update_AssemblyFileName;
		Update_AssemblyFileName = nullptr;
	}
	if (Update_AssemblyName)
	{
		delete[] Update_AssemblyName;
		Update_AssemblyName = nullptr;
	}


	if (ShimProxy_CLSID)
	{
		delete[] ShimProxy_CLSID;
		ShimProxy_CLSID = nullptr;
	}
	if (ShimProxy_ProgID)
	{
		delete[] ShimProxy_ProgID;
		ShimProxy_ProgID = nullptr;
	}
	if (ShimProxy_Version)
	{
		delete[] ShimProxy_Version;
		ShimProxy_Version = nullptr;
	}
	if (ShimProxy_FriendlyName)
	{
		delete[] ShimProxy_FriendlyName;
		ShimProxy_FriendlyName = nullptr;
	}
	if (ShimProxy_Description)
	{
		delete[] ShimProxy_Description;
		ShimProxy_Description = nullptr;
	}


	if (Target_ConfigFileName)
	{
		delete[] Target_ConfigFileName;
		Target_ConfigFileName = nullptr;
	}
	if (Target_ConnectClassName)
	{
		delete[] Target_ConnectClassName;
		Target_ConnectClassName = nullptr;
	}
	if (Target_AssemblyFileName)
	{
		delete[] Target_AssemblyFileName;
		Target_AssemblyFileName = nullptr;
	}
	if (Target_AssemblyName)
	{
		delete[] Target_AssemblyName;
		Target_AssemblyName = nullptr;
	}

	if (TargetManagedAggregator_AppDomain_BaseFolder)
	{
		delete[] TargetManagedAggregator_AppDomain_BaseFolder;
		TargetManagedAggregator_AppDomain_BaseFolder = nullptr;
	}

	if (TargetManagedAggregator_AppDomain_FriendlyName)
	{
		delete[] TargetManagedAggregator_AppDomain_FriendlyName;
		TargetManagedAggregator_AppDomain_FriendlyName = nullptr;
	}

	if (TargetManagedAggregator_ClassName)
	{
		delete[] TargetManagedAggregator_ClassName;
		TargetManagedAggregator_ClassName = nullptr;
	}

	if (TargetManagedAggregator_AssemblyName)
	{
		delete[] TargetManagedAggregator_AssemblyName;
		TargetManagedAggregator_AssemblyName = nullptr;
	}

	if (TargetManagedAggregator_Folder)
	{
		delete[] TargetManagedAggregator_Folder;
		TargetManagedAggregator_Folder = nullptr;
	}

	NetOffice_ShimLoader_Analytics::WriteLog(L"DllMain::Cleanup::Exit");

	if (LogFile_Register_Path)
	{
		delete[] LogFile_Register_Path;
		LogFile_Register_Path = nullptr;
	}

	if (LogFile_UnRegister_Path)
	{
		delete[] LogFile_UnRegister_Path;
		LogFile_UnRegister_Path = nullptr;
	}

	if (LogFile_Path)
	{
		delete[] LogFile_Path;
		LogFile_Path = nullptr;
	}
}

bool Is64BitWindows(bool & isWindows64bit)
{
#if _WIN64

	isWindows64bit = true;
	return true;

#elif _WIN32

	BOOL isWow64 = FALSE;
	LPFN_ISWOW64PROCESS fnIsWow64Process = (LPFN_ISWOW64PROCESS)GetProcAddress(GetModuleHandle(TEXT("kernel32")), "IsWow64Process");

	if (fnIsWow64Process)
	{
		if (!fnIsWow64Process(GetCurrentProcess(), &isWow64))
			return false;

		if (isWow64)
			isWindows64bit = true;
		else
			isWindows64bit = false;

		return true;
	}
	else
		return false;

#else

	assert(0);
	return false;

#endif
}

void IncComponents(LPCWSTR type)
{
#ifdef DEBUG
	_componentsMap[type] = ++_componentsMap[type];
#endif
	_components++;
}

void DecComponents(LPCWSTR type)
{
#ifdef DEBUG
	_componentsMap[type] = --_componentsMap[type];
	if (_componentsMap[type] == 0)
		_componentsMap.erase(type);
#endif
	_components--;
}