using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using LateBindingApi.Core;

namespace NetOffice.OutlookApi
{	
	#pragma warning disable
	
	#region SinkPoint Interface

	[SupportByLibrary("Outlook", 14)]
	[ComImport, Guid("00063105-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIDispatch), TypeLibType((short)0x1010)]
	public interface AccountsEvents
	{
		[SupportByLibrary("Outlook", 14)]
		[PreserveSig, MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime), DispId(64620)]
		void AutoDiscoverComplete([In, MarshalAs(UnmanagedType.IDispatch)] object account);
	}
	
	#endregion
	
	#region SinkHelper
	
	[ComVisible(true), ClassInterface(ClassInterfaceType.None), TypeLibType(TypeLibTypeFlags.FHidden)]
	public class AccountsEvents_SinkHelper : SinkHelper, AccountsEvents
	{
		#region Static
		
		public static readonly string Id = "00063105-0000-0000-C000-000000000046";
		
		#endregion
	
		#region Fields

		private IEventBinding	_eventBinding;
        private COMObject		_eventClass;
        
		#endregion
		
		#region Construction

		public AccountsEvents_SinkHelper(COMObject eventClass, IConnectionPoint connectPoint): base(eventClass)
		{
			_eventClass = eventClass;
			_eventBinding = (IEventBinding)eventClass;
			SetupEventBinding(connectPoint);
		}
		
		#endregion
		
		#region AccountsEvents Members
		
		public void AutoDiscoverComplete([In, MarshalAs(UnmanagedType.IDispatch)] object account)
		{
			Delegate[] recipients = _eventBinding.GetEventRecipients("AutoDiscoverComplete");
			if( (true == _eventClass.IsCurrentlyDisposing) || (recipients.Length == 0) )
			{
				Invoker.ReleaseParamsArray(account);
				return;
			}

			NetOffice.OutlookApi.Account newAccount = LateBindingApi.Core.Factory.CreateObjectFromComProxy(_eventClass, account) as NetOffice.OutlookApi.Account;
			object[] paramsArray = new object[1];
			paramsArray[0] = newAccount;
			foreach(Delegate delItem in recipients)
				delItem.Method.Invoke(delItem.Target, paramsArray);
		}

		#endregion
	}
	
	#endregion
	
	#pragma warning restore
}