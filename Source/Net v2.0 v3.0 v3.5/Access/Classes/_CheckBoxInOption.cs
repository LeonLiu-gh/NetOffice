//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{

	#region Delegates

	#pragma warning disable
	public delegate void _CheckBoxInOption_GotFocusEventHandler();
	public delegate void _CheckBoxInOption_LostFocusEventHandler();
	public delegate void _CheckBoxInOption_MouseDownEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void _CheckBoxInOption_MouseMoveEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void _CheckBoxInOption_MouseUpEventHandler(ref Int16 Button, ref Int16 Shift, ref Single X, ref Single Y);
	public delegate void _CheckBoxInOption_KeyDownEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void _CheckBoxInOption_KeyPressEventHandler(ref Int16 KeyAscii);
	public delegate void _CheckBoxInOption_KeyUpEventHandler(ref Int16 KeyCode, ref Int16 Shift);
	public delegate void _CheckBoxInOption_ClickEventHandler();
	public delegate void _CheckBoxInOption_BeforeUpdateEventHandler(ref Int16 Cancel);
	public delegate void _CheckBoxInOption_AfterUpdateEventHandler();
	public delegate void _CheckBoxInOption_EnterEventHandler();
	public delegate void _CheckBoxInOption_ExitEventHandler(ref Int16 Cancel);
	public delegate void _CheckBoxInOption_DblClickEventHandler(ref Int16 Cancel);
	#pragma warning restore

	#endregion

	///<summary>
	/// CoClass _CheckBoxInOption SupportByLibrary AC09 AC10 AC11 AC12 AC14 
	///</summary>
	[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
	public class _CheckBoxInOption : _Checkbox, IEventBinding 
	{
		#pragma warning disable
		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
		private NetRuntimeSystem.Type _thisType;
		_CheckBoxInOptionEvents_SinkHelper __CheckBoxInOptionEvents_SinkHelper;
		DispCheckBoxEvents_SinkHelper _dispCheckBoxEvents_SinkHelper;
	
		#endregion
		
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CheckBoxInOption(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CheckBoxInOption(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _CheckBoxInOption(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		public _CheckBoxInOption()
		{
			CreateFromProgId("Access._CheckBoxInOption");
		}
		
		/// <param name="progId">progId</param>
		public _CheckBoxInOption(string progId)
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
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, _CheckBoxInOptionEvents_SinkHelper.Id,DispCheckBoxEvents_SinkHelper.Id);


			if(_CheckBoxInOptionEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				__CheckBoxInOptionEvents_SinkHelper = new _CheckBoxInOptionEvents_SinkHelper(this, _connectPoint);
				return;
			}

			if(DispCheckBoxEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_dispCheckBoxEvents_SinkHelper = new DispCheckBoxEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }
		
		#endregion

		#region Events

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event _CheckBoxInOption_GotFocusEventHandler _GotFocusEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event _CheckBoxInOption_GotFocusEventHandler GotFocusEvent
		{
			add
			{
				CreateEventBridge();
				_GotFocusEvent += value;
			}
			remove
			{
				_GotFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event _CheckBoxInOption_LostFocusEventHandler _LostFocusEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event _CheckBoxInOption_LostFocusEventHandler LostFocusEvent
		{
			add
			{
				CreateEventBridge();
				_LostFocusEvent += value;
			}
			remove
			{
				_LostFocusEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event _CheckBoxInOption_MouseDownEventHandler _MouseDownEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event _CheckBoxInOption_MouseDownEventHandler MouseDownEvent
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
		private event _CheckBoxInOption_MouseMoveEventHandler _MouseMoveEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event _CheckBoxInOption_MouseMoveEventHandler MouseMoveEvent
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
		private event _CheckBoxInOption_MouseUpEventHandler _MouseUpEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event _CheckBoxInOption_MouseUpEventHandler MouseUpEvent
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

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event _CheckBoxInOption_KeyDownEventHandler _KeyDownEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event _CheckBoxInOption_KeyDownEventHandler KeyDownEvent
		{
			add
			{
				CreateEventBridge();
				_KeyDownEvent += value;
			}
			remove
			{
				_KeyDownEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event _CheckBoxInOption_KeyPressEventHandler _KeyPressEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event _CheckBoxInOption_KeyPressEventHandler KeyPressEvent
		{
			add
			{
				CreateEventBridge();
				_KeyPressEvent += value;
			}
			remove
			{
				_KeyPressEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		private event _CheckBoxInOption_KeyUpEventHandler _KeyUpEvent;

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public event _CheckBoxInOption_KeyUpEventHandler KeyUpEvent
		{
			add
			{
				CreateEventBridge();
				_KeyUpEvent += value;
			}
			remove
			{
				_KeyUpEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14
		/// </summary>
		private event _CheckBoxInOption_ClickEventHandler _ClickEvent;

		/// <summary>
		/// SupportByLibrary AC12 AC14
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public event _CheckBoxInOption_ClickEventHandler ClickEvent
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
		/// SupportByLibrary AC12 AC14
		/// </summary>
		private event _CheckBoxInOption_BeforeUpdateEventHandler _BeforeUpdateEvent;

		/// <summary>
		/// SupportByLibrary AC12 AC14
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public event _CheckBoxInOption_BeforeUpdateEventHandler BeforeUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeUpdateEvent += value;
			}
			remove
			{
				_BeforeUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14
		/// </summary>
		private event _CheckBoxInOption_AfterUpdateEventHandler _AfterUpdateEvent;

		/// <summary>
		/// SupportByLibrary AC12 AC14
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public event _CheckBoxInOption_AfterUpdateEventHandler AfterUpdateEvent
		{
			add
			{
				CreateEventBridge();
				_AfterUpdateEvent += value;
			}
			remove
			{
				_AfterUpdateEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14
		/// </summary>
		private event _CheckBoxInOption_EnterEventHandler _EnterEvent;

		/// <summary>
		/// SupportByLibrary AC12 AC14
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public event _CheckBoxInOption_EnterEventHandler EnterEvent
		{
			add
			{
				CreateEventBridge();
				_EnterEvent += value;
			}
			remove
			{
				_EnterEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14
		/// </summary>
		private event _CheckBoxInOption_ExitEventHandler _ExitEvent;

		/// <summary>
		/// SupportByLibrary AC12 AC14
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public event _CheckBoxInOption_ExitEventHandler ExitEvent
		{
			add
			{
				CreateEventBridge();
				_ExitEvent += value;
			}
			remove
			{
				_ExitEvent -= value;
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14
		/// </summary>
		private event _CheckBoxInOption_DblClickEventHandler _DblClickEvent;

		/// <summary>
		/// SupportByLibrary AC12 AC14
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public event _CheckBoxInOption_DblClickEventHandler DblClickEvent
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
			if( null != __CheckBoxInOptionEvents_SinkHelper)
			{
				__CheckBoxInOptionEvents_SinkHelper.Dispose();
				__CheckBoxInOptionEvents_SinkHelper = null;
			}
			if( null != _dispCheckBoxEvents_SinkHelper)
			{
				_dispCheckBoxEvents_SinkHelper.Dispose();
				_dispCheckBoxEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion
		#pragma warning restore
	}
}