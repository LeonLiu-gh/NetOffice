﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
	/// <summary>
	/// DispatchInterface WorksheetView 
	/// SupportByVersion Excel, 12,14,15,16
	/// </summary>
	/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836530.aspx </remarks>
	[SupportByVersion("Excel", 12,14,15,16)]
	[EntityType(EntityType.IsDispatchInterface)]
 	public class WorksheetView : COMObject, NetOffice.ExcelApi.WorksheetView
	{
		#pragma warning disable

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
                    _contractType = typeof(NetOffice.ExcelApi.WorksheetView);
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

        private static Type _type;
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(WorksheetView);
                return _type;
            }
        }
        
        #endregion
        
		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public WorksheetView() : base()
		{

		}

		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822595.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Application Application
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197696.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff841202.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16), ProxyResult]
		public virtual object Parent
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// Unknown COM Proxy
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834337.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16), ProxyResult]
		public virtual object Sheet
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Sheet");
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821646.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool DisplayGridlines
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "DisplayGridlines");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "DisplayGridlines", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835913.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool DisplayFormulas
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "DisplayFormulas");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "DisplayFormulas", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195340.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool DisplayHeadings
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "DisplayHeadings");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "DisplayHeadings", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837137.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool DisplayOutline
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "DisplayOutline");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "DisplayOutline", value);
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get/Set
		/// </summary>
		/// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834403.aspx </remarks>
		[SupportByVersion("Excel", 12,14,15,16)]
		public virtual bool DisplayZeros
		{
			get
			{
				return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "DisplayZeros");
			}
			set
			{
				InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "DisplayZeros", value);
			}
		}

		#endregion

		#region Methods

		#endregion

		#pragma warning restore
	}
}


