//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.VBIDEApi
{

	#region Delegates

	#pragma warning disable
	public delegate void References_ItemAddedEventHandler(NetOffice.VBIDEApi.Reference Reference);
	public delegate void References_ItemRemovedEventHandler(NetOffice.VBIDEApi.Reference Reference);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass References SupportByLibrary VBE5.3 VBE12 
	///</summary>
	[SupportByLibrary("VBE5.3","VBE12")]
	public class References : _References, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_dispReferences_Events_SinkHelper __dispReferences_Events_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public References(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public References(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public References(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public References()
		{
			CreateFromProgId("VBIDE.References");
		}
		
		/// <param name="progId">progId</param>
		public References(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _dispReferences_Events_SinkHelper.Id);


			if(_dispReferences_Events_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__dispReferences_Events_SinkHelper = new _dispReferences_Events_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12
		/// </summary>
		private event References_ItemAddedEventHandler _ItemAddedEvent;

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12
		/// </summary>
		[SupportByLibrary("VBE5.3","VBE12")]
		public event References_ItemAddedEventHandler ItemAddedEvent
		{
			add
			{
				CreateEventBridge();
				_ItemAddedEvent += value;
			}
			remove
			{
				_ItemAddedEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12
		/// </summary>
		private event References_ItemRemovedEventHandler _ItemRemovedEvent;

		/// <summary>
		/// SupportByLibrary VBE5.3 VBE12
		/// </summary>
		[SupportByLibrary("VBE5.3","VBE12")]
		public event References_ItemRemovedEventHandler ItemRemovedEvent
		{
			add
			{
				CreateEventBridge();
				_ItemRemovedEvent += value;
			}
			remove
			{
				_ItemRemovedEvent -= value;
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
			if( null != __dispReferences_Events_SinkHelper)
			{
				__dispReferences_Events_SinkHelper.Dispose();
				__dispReferences_Events_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}