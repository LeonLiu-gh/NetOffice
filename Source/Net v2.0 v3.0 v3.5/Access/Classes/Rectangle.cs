//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void Rectangle_ClickEventHandler();
	public delegate void Rectangle_DblClickEventHandler(ref Int16 Cancel);
	public delegate void Rectangle_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void Rectangle_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void Rectangle_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass Rectangle SupportByLibrary AC09 AC10 AC11 AC12 AC14 
	///</summary>
	[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
	public class Rectangle : _Rectangle, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_RectangleEvents_SinkHelper __RectangleEvents_SinkHelper;
		DispRectangleEvents_SinkHelper _dispRectangleEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Rectangle(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Rectangle(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Rectangle(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public Rectangle()
		{
			CreateFromProgId("Access.Rectangle");
		}
		
		/// <param name="progId">progId</param>
		public Rectangle(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _RectangleEvents_SinkHelper.Id,DispRectangleEvents_SinkHelper.Id);


			if(_RectangleEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__RectangleEvents_SinkHelper = new _RectangleEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(DispRectangleEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_dispRectangleEvents_SinkHelper = new DispRectangleEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event Rectangle_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event Rectangle_ClickEventHandler ClickEvent
		{
			add
			{
				CreateEventBridge();
				_ClickEvent += value;
			}
			remove
			{
				_ClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event Rectangle_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event Rectangle_DblClickEventHandler DblClickEvent
		{
			add
			{
				CreateEventBridge();
				_DblClickEvent += value;
			}
			remove
			{
				_DblClickEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event Rectangle_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event Rectangle_MouseDownEventHandler MouseDownEvent
		{
			add
			{
				CreateEventBridge();
				_MouseDownEvent += value;
			}
			remove
			{
				_MouseDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event Rectangle_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event Rectangle_MouseMoveEventHandler MouseMoveEvent
		{
			add
			{
				CreateEventBridge();
				_MouseMoveEvent += value;
			}
			remove
			{
				_MouseMoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event Rectangle_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event Rectangle_MouseUpEventHandler MouseUpEvent
		{
			add
			{
				CreateEventBridge();
				_MouseUpEvent += value;
			}
			remove
			{
				_MouseUpEvent -= value;
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
			if( null != __RectangleEvents_SinkHelper)
			{
				__RectangleEvents_SinkHelper.Dispose();
				__RectangleEvents_SinkHelper = null;
			}
			if( null != _dispRectangleEvents_SinkHelper)
			{
				_dispRectangleEvents_SinkHelper.Dispose();
				_dispRectangleEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}