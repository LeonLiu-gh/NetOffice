﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// Interface IWorksheetDataConnection 
	/// SupportByVersion Excel, 15, 16
	/// </summary>
	[SupportByVersion("Excel", 15, 16)]
	[EntityType(EntityType.IsInterface)]
 	public class IWorksheetDataConnection : COMObject, NetOffice.ExcelApi.IWorksheetDataConnection
	{
		#pragma warning disable

		#region Type Information

        /// <summary>        /// Instance Type
        /// </summary>
		[EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(IWorksheetDataConnection);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public IWorksheetDataConnection() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		[SupportByVersion("Excel", 15, 16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public virtual object Connection
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Connection");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public virtual object CommandText
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "CommandText");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "CommandText", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 15,16
		/// Get/Set
		/// </summary>
		[SupportByVersion("Excel", 15, 16)]
		public virtual NetOffice.ExcelApi.Enums.XlCmdType CommandType
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCmdType>(this, "CommandType");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "CommandType", value);
			}
		}

		#endregion

		#region Methods

		#endregion

		#pragma warning restore
	}
}


