﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.OutlookApi.Behind
{
	/// <summary>
	/// CoClass Reminders 
	/// SupportByVersion Outlook, 10,11,12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff866017.aspx </remarks>
	[SupportByVersion("Outlook", 10,11,12,14,15,16)]
	[EntityType(EntityType.IsCoClass)]
    [ComEventContract(typeof(NetOffice.OutlookApi.EventContracts.ReminderCollectionEvents))]
    public class Reminders : _Reminders, NetOffice.OutlookApi.Reminders
    {
		#pragma warning disable

		#region Fields
		
		private NetRuntimeSystem.Runtime.InteropServices.ComTypes.IConnectionPoint _connectPoint;
		private string _activeSinkId;
        private static Type _type;
        private NetOffice.OutlookApi.Behind.EventContracts.ReminderCollectionEvents_SinkHelper _reminderCollectionEvents_SinkHelper;
	
		#endregion

		#region Type Information

        /// <summary>
        /// Contract Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type ContractType
        {
            get
            {
                if(null == _contractType)
                    _contractType = typeof(NetOffice.OutlookApi.Reminders);
                return _contractType;
            }
        }
        private static Type _contractType;


        /// <summary>
        /// Instance Type
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }
        
        /// <summary>
        /// Type Cache
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(Reminders);
                return _type;
            }
        }
        
        #endregion
        		
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public Reminders() : base()
		{

		}

		#endregion

		#region Events

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14,15,16
		/// </summary>
		private event Reminders_BeforeReminderShowEventHandler _BeforeReminderShowEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14 15,16
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff867326.aspx </remarks>
		[SupportByVersion("Outlook", 10,11,12,14,15,16)]
		public event Reminders_BeforeReminderShowEventHandler BeforeReminderShowEvent
		{
			add
			{
				CreateEventBridge();
				_BeforeReminderShowEvent += value;
			}
			remove
			{
				_BeforeReminderShowEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14,15,16
		/// </summary>
		private event Reminders_ReminderAddEventHandler _ReminderAddEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14 15,16
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869105.aspx </remarks>
		[SupportByVersion("Outlook", 10,11,12,14,15,16)]
		public event Reminders_ReminderAddEventHandler ReminderAddEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderAddEvent += value;
			}
			remove
			{
				_ReminderAddEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14,15,16
		/// </summary>
		private event Reminders_ReminderChangeEventHandler _ReminderChangeEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14 15,16
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff863669.aspx </remarks>
		[SupportByVersion("Outlook", 10,11,12,14,15,16)]
		public event Reminders_ReminderChangeEventHandler ReminderChangeEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderChangeEvent += value;
			}
			remove
			{
				_ReminderChangeEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14,15,16
		/// </summary>
		private event Reminders_ReminderFireEventHandler _ReminderFireEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14 15,16
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff866477.aspx </remarks>
		[SupportByVersion("Outlook", 10,11,12,14,15,16)]
		public event Reminders_ReminderFireEventHandler ReminderFireEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderFireEvent += value;
			}
			remove
			{
				_ReminderFireEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14,15,16
		/// </summary>
		private event Reminders_ReminderRemoveEventHandler _ReminderRemoveEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14 15,16
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff869874.aspx </remarks>
		[SupportByVersion("Outlook", 10,11,12,14,15,16)]
		public event Reminders_ReminderRemoveEventHandler ReminderRemoveEvent
		{
			add
			{
				CreateEventBridge();
				_ReminderRemoveEvent += value;
			}
			remove
			{
				_ReminderRemoveEvent -= value;
			}
		}

		/// <summary>
		/// SupportByVersion Outlook, 10,11,12,14,15,16
		/// </summary>
		private event Reminders_SnoozeEventHandler _SnoozeEvent;

		/// <summary>
		/// SupportByVersion Outlook 10 11 12 14 15,16
		/// </summary>
		///<remarks> MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff862485.aspx </remarks>
		[SupportByVersion("Outlook", 10,11,12,14,15,16)]
		public event Reminders_SnoozeEventHandler SnoozeEvent
		{
			add
			{
				CreateEventBridge();
				_SnoozeEvent += value;
			}
			remove
			{
				_SnoozeEvent -= value;
			}
		}

		#endregion
       
	    #region IEventBinding
        
		/// <summary>
        /// Creates active sink helper
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public void CreateEventBridge()
        {
			if(false == Factory.Settings.EnableEvents)
				return;
	
			if (null != _connectPoint)
				return;
	
            if (null == _activeSinkId)
				_activeSinkId = SinkHelper.GetConnectionPoint(this, ref _connectPoint, NetOffice.OutlookApi.Behind.EventContracts.ReminderCollectionEvents_SinkHelper.Id);


			if(NetOffice.OutlookApi.Behind.EventContracts.ReminderCollectionEvents_SinkHelper.Id.Equals(_activeSinkId, StringComparison.InvariantCultureIgnoreCase))
			{
				_reminderCollectionEvents_SinkHelper = new NetOffice.OutlookApi.Behind.EventContracts.ReminderCollectionEvents_SinkHelper(this, _connectPoint);
				return;
			} 
        }

        /// <summary>
        /// The instance use currently an event listener 
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool EventBridgeInitialized
        {
            get 
            {
                return (null != _connectPoint);
            }
        }
        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <returns>true if one or more event is active, otherwise false</returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients()       
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType);            
        }

        /// <summary>
        /// Instance has one or more event recipients
        /// </summary>
        /// <param name="eventName">name of the event</param>
        /// <returns></returns>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public bool HasEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.HasEventRecipients(this, LateBindingApiWrapperType, eventName);
        }

        /// <summary>
        /// Target methods from its actual event recipients
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public Delegate[] GetEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetEventRecipients(this, LateBindingApiWrapperType, eventName);
        }
       
        /// <summary>
        /// Returns the current count of event recipients
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int GetCountOfEventRecipients(string eventName)
        {
            return NetOffice.Events.CoClassEventReflector.GetCountOfEventRecipients(this, LateBindingApiWrapperType, eventName);       
         }
        
        /// <summary>
        /// Raise an instance event
        /// </summary>
        /// <param name="eventName">name of the event without 'Event' at the end</param>
        /// <param name="paramsArray">custom arguments for the event</param>
        /// <returns>count of called event recipients</returns>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public int RaiseCustomEvent(string eventName, ref object[] paramsArray)
		{
            return NetOffice.Events.CoClassEventReflector.RaiseCustomEvent(this, LateBindingApiWrapperType, eventName, ref paramsArray);
		}
        /// <summary>
        /// Stop listening events for the instance
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public void DisposeEventBridge()
        {
			if( null != _reminderCollectionEvents_SinkHelper)
			{
				_reminderCollectionEvents_SinkHelper.Dispose();
				_reminderCollectionEvents_SinkHelper = null;
			}

			_connectPoint = null;
		}
        
        #endregion

		#pragma warning restore
	}
}
