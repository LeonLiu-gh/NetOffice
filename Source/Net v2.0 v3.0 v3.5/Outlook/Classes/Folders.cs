//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Folders_FolderAddEventHandler(NetOffice.OutlookApi.MAPIFolder Folder);
	public delegate void Folders_FolderChangeEventHandler(NetOffice.OutlookApi.MAPIFolder Folder);
	public delegate void Folders_FolderRemoveEventHandler();
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Folders SupportByLibrary OL09 OL10 OL11 OL12 OL14 
	///</summary>
	[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
	public class Folders : _Folders, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		FoldersEvents_SinkHelper _foldersEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Folders(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Folders(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Folders(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public Folders()
		{
			CreateFromProgId("Outlook.Folders");
		}
		
		/// <param name="progId">progId</param>
		public Folders(string progId)
		{
			CreateFromProgId(progId);
		}

		#endregion
		
		#region Private Methods
		
		/// <summary>
        /// creates active sink helper
        /// </summary>
		private void CreateEventBridge()
        {
			if(false == LateBindingApi.Core.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, FoldersEvents_SinkHelper.Id);


			if(FoldersEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_foldersEvents_SinkHelper = new FoldersEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event Folders_FolderAddEventHandler _FolderAddEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event Folders_FolderAddEventHandler FolderAddEvent
		{
			add
			{
				CreateEventBridge();
				_FolderAddEvent += value;
			}
			remove
			{
				_FolderAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event Folders_FolderChangeEventHandler _FolderChangeEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event Folders_FolderChangeEventHandler FolderChangeEvent
		{
			add
			{
				CreateEventBridge();
				_FolderChangeEvent += value;
			}
			remove
			{
				_FolderChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		private event Folders_FolderRemoveEventHandler _FolderRemoveEvent;

		/// <summary>
		/// SupportByLibrary OL09 OL10 OL11 OL12 OL14
		/// </summary>
		[SupportByLibrary("OL09","OL10","OL11","OL12","OL14")]
		public event Folders_FolderRemoveEventHandler FolderRemoveEvent
		{
			add
			{
				CreateEventBridge();
				_FolderRemoveEvent += value;
			}
			remove
			{
				_FolderRemoveEvent -= value;
			}
		}

		#endregion

        #region IEventBinding Member
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients       
        {
			get
			{
				if(null == _thisType)
					_thisType = this.GetType();
					
				foreach (NetRuntimeSystem.Reflection.EventInfo item in _thisType.GetEvents())
				{
					MulticastDelegate eventDelegate = (MulticastDelegate) _thisType.GetType().GetField(item.Name, 
																			NetRuntimeSystem.Reflection.BindingFlags.NonPublic |
																			NetRuntimeSystem.Reflection.BindingFlags.Instance).GetValue(this);
					
					if( (null != eventDelegate) && (eventDelegate.GetInvocationList().Length > 0) )
						return false;
				}
				
				return false;
			}
        }
        
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
			if(null == _thisType)
				_thisType = this.GetType();
             
            MulticastDelegate eventDelegate = (MulticastDelegate)_thisType.GetField(
                                                "_" + eventName + "Event",
                                                NetRuntimeSystem.Reflection.BindingFlags.Instance |
                                                NetRuntimeSystem.Reflection.BindingFlags.NonPublic).GetValue(this);

            if (null != eventDelegate)
            {
                Delegate[] delegates = eventDelegate.GetInvocationList();
                return delegates;
            }
            else
                return new Delegate[0];
        }

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeSinkHelper()
        {
			if( null != _foldersEvents_SinkHelper)
			{
				_foldersEvents_SinkHelper.Dispose();
				_foldersEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}