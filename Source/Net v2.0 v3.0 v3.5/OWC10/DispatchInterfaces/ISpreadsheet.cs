//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface ISpreadsheet SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	public class ISpreadsheet : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISpreadsheet(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISpreadsheet(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISpreadsheet(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISpreadsheet()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api._Range ActiveCell
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveCell", paramsArray);
				NetOffice.OWC10Api._Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api._Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.Worksheet ActiveSheet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveSheet", paramsArray);
				NetOffice.OWC10Api.Worksheet newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.Worksheet;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.Window ActiveWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveWindow", paramsArray);
				NetOffice.OWC10Api.Window newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.Window;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.Workbook ActiveWorkbook
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ActiveWorkbook", paramsArray);
				NetOffice.OWC10Api.Workbook newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.Workbook;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool AllowPropertyToolbox
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AllowPropertyToolbox", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AllowPropertyToolbox", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.ISpreadsheet Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OWC10Api.ISpreadsheet newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.ISpreadsheet;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool AutoFit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AutoFit", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AutoFit", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 Build
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Build", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string BuildNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BuildNumber", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.Enums.XlCalculation Calculation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Calculation", paramsArray);
				return (NetOffice.OWC10Api.Enums.XlCalculation)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Calculation", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 CalculationVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CalculationVersion", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool CanUndo
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CanUndo", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string Caption
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Caption", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Caption", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api._Range Cells
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Cells", paramsArray);
				NetOffice.OWC10Api._Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api._Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api._Range Columns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Columns", paramsArray);
				NetOffice.OWC10Api._Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api._Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.OCCommands Commands
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Commands", paramsArray);
				NetOffice.OWC10Api.OCCommands newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.OCCommands;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public COMObject Constants
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Constants", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string CSVData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CSVData", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CSVData", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string CSVURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CSVURL", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CSVURL", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string DataMember
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataMember", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataMember", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.MSDATASRCApi.DataSource DataSource
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataSource", paramsArray);
				NetOffice.MSDATASRCApi.DataSource newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSDATASRCApi.DataSource;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataSource", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string DataType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataType", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DataType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DesignMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DesignMode", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool Dirty
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Dirty", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Dirty", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DisplayBranding
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayBranding", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayBranding", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DisplayColumnHeadings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayColumnHeadings", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayColumnHeadings", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DisplayDesignTimeUI
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayDesignTimeUI", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayDesignTimeUI", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DisplayGridlines
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayGridlines", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayGridlines", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DisplayHorizontalScrollBar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayHorizontalScrollBar", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayHorizontalScrollBar", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DisplayOfficeLogo
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayOfficeLogo", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayOfficeLogo", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DisplayPropertyToolbox
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayPropertyToolbox", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayPropertyToolbox", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DisplayRowHeadings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayRowHeadings", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayRowHeadings", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DisplayTitleBar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayTitleBar", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayTitleBar", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DisplayToolbar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayToolbar", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayToolbar", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DisplayVerticalScrollBar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayVerticalScrollBar", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayVerticalScrollBar", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool DisplayWorkbookTabs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayWorkbookTabs", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayWorkbookTabs", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool EnableEvents
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableEvents", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableEvents", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool EnableUndo
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableUndo", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableUndo", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string HTMLData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HTMLData", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HTMLData", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string HTMLURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HTMLURL", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HTMLURL", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 InstanceID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InstanceID", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XWC1.0")]
		public object get_International(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "International", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.OWCLanguageSettings LanguageSettings
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LanguageSettings", paramsArray);
				NetOffice.OWC10Api.OWCLanguageSettings newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.OWCLanguageSettings;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public object MaxHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MaxHeight", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MaxHeight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public object MaxWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MaxWidth", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MaxWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Int32 MajorVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MajorVersion", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string MinorVersion
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MinorVersion", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool MoveAfterReturn
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MoveAfterReturn", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MoveAfterReturn", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.Enums.XlDirection MoveAfterReturnDirection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MoveAfterReturnDirection", paramsArray);
				return (NetOffice.OWC10Api.Enums.XlDirection)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MoveAfterReturnDirection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.Names Names
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Names", paramsArray);
				NetOffice.OWC10Api.Names newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.Names;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Cell1">object Cell1</param>
		/// <param name="Cell2">optional object Cell2</param>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api._Range get_Range(object cell1, object cell2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cell1, cell2);
			object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
			NetOffice.OWC10Api._Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api._Range;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Cell1">object Cell1</param>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api._Range get_Range(object cell1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cell1);
			object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
			NetOffice.OWC10Api._Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api._Range;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string RevisionNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RevisionNumber", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool RightToLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RightToLeft", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RightToLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api._Range Rows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Rows", paramsArray);
				NetOffice.OWC10Api._Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api._Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool ScreenUpdating
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScreenUpdating", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ScreenUpdating", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api._Range Selection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Selection", paramsArray);
				NetOffice.OWC10Api._Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api._Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.Sheets Sheets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sheets", paramsArray);
				NetOffice.OWC10Api.Sheets newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.Sheets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.TitleBar TitleBar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TitleBar", paramsArray);
				NetOffice.OWC10Api.TitleBar newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.TitleBar;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.MSComctlLibApi.IToolbar Toolbar
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Toolbar", paramsArray);
				NetOffice.MSComctlLibApi.IToolbar newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IToolbar;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string Value
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Value", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string Version
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Version", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string ViewableRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ViewableRange", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ViewableRange", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public bool ViewOnlyMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ViewOnlyMode", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.Windows Windows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Windows", paramsArray);
				NetOffice.OWC10Api.Windows newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.Windows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.Workbooks Workbooks
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Workbooks", paramsArray);
				NetOffice.OWC10Api.Workbooks newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.Workbooks;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.Worksheets Worksheets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Worksheets", paramsArray);
				NetOffice.OWC10Api.Worksheets newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.Worksheets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string XMLData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XMLData", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "XMLData", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string XMLURL
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XMLURL", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "XMLURL", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="AddIn">object AddIn</param>
		[SupportByLibrary("XWC1.0")]
		public void AddIn(object addIn)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(addIn);
			Invoker.Method(this, "AddIn", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void BeginUndo()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "BeginUndo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void Calculate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Calculate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void CalculateFull()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "CalculateFull", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Cancel">bool Cancel</param>
		[SupportByLibrary("XWC1.0")]
		public void EndUndo(bool cancel)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(cancel);
			Invoker.Method(this, "EndUndo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Expression">object Expression</param>
		[SupportByLibrary("XWC1.0")]
		public object _Evaluate(object expression)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression);
			object returnItem = Invoker.MethodReturn(this, "_Evaluate", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Expression">object Expression</param>
		[SupportByLibrary("XWC1.0")]
		public object Evaluate(object expression)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(expression);
			object returnItem = Invoker.MethodReturn(this, "Evaluate", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Filename">string Filename</param>
		/// <param name="Action">NetOffice.OWC10Api.Enums.SheetExportActionEnum Action</param>
		/// <param name="Format">NetOffice.OWC10Api.Enums.SheetExportFormat Format</param>
		[SupportByLibrary("XWC1.0")]
		public void Export(string filename, NetOffice.OWC10Api.Enums.SheetExportActionEnum action, NetOffice.OWC10Api.Enums.SheetExportFormat format)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(filename, action, format);
			Invoker.Method(this, "Export", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void LocateDataSource()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "LocateDataSource", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="bstr">string bstr</param>
		[SupportByLibrary("XWC1.0")]
		public COMObject msDataSourceObject(string bstr)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstr);
			object returnItem = Invoker.MethodReturn(this, "msDataSourceObject", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Range1">NetOffice.OWC10Api._Range Range1</param>
		/// <param name="Range2">NetOffice.OWC10Api._Range Range2</param>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api._Range RectIntersect(NetOffice.OWC10Api._Range range1, NetOffice.OWC10Api._Range range2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range1, range2);
			object returnItem = Invoker.MethodReturn(this, "RectIntersect", paramsArray);
			NetOffice.OWC10Api._Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OWC10Api._Range;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Range1">NetOffice.OWC10Api._Range Range1</param>
		/// <param name="Range2">NetOffice.OWC10Api._Range Range2</param>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api._Range RectUnion(NetOffice.OWC10Api._Range range1, NetOffice.OWC10Api._Range range2)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(range1, range2);
			object returnItem = Invoker.MethodReturn(this, "RectUnion", paramsArray);
			NetOffice.OWC10Api._Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OWC10Api._Range;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void Repaint()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Repaint", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void ShowAbout()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ShowAbout", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="x">Int32 x</param>
		/// <param name="y">Int32 y</param>
		/// <param name="Menu">object Menu</param>
		[SupportByLibrary("XWC1.0")]
		public void ShowContextMenu(Int32 x, Int32 y, object menu)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(x, y, menu);
			Invoker.Method(this, "ShowContextMenu", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Topic">Int32 Topic</param>
		[SupportByLibrary("XWC1.0")]
		public void ShowHelp(Int32 topic)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(topic);
			Invoker.Method(this, "ShowHelp", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void Undo()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Undo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void UpdatePropertyToolbox()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "UpdatePropertyToolbox", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}