//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface LineFormat SupportByLibrary OF09 OF10 OF11 OF12 OF14 
	///</summary>
	[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
	public class LineFormat : _IMsoDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LineFormat(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LineFormat(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LineFormat(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LineFormat()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.ColorFormat BackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackColor", paramsArray);
				NetOffice.OfficeApi.ColorFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.ColorFormat;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoArrowheadLength BeginArrowheadLength
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BeginArrowheadLength", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoArrowheadLength)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BeginArrowheadLength", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoArrowheadStyle BeginArrowheadStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BeginArrowheadStyle", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoArrowheadStyle)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BeginArrowheadStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoArrowheadWidth BeginArrowheadWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BeginArrowheadWidth", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoArrowheadWidth)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BeginArrowheadWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoLineDashStyle DashStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DashStyle", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoLineDashStyle)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DashStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoArrowheadLength EndArrowheadLength
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EndArrowheadLength", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoArrowheadLength)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EndArrowheadLength", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoArrowheadStyle EndArrowheadStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EndArrowheadStyle", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoArrowheadStyle)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EndArrowheadStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoArrowheadWidth EndArrowheadWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EndArrowheadWidth", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoArrowheadWidth)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EndArrowheadWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.ColorFormat ForeColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ForeColor", paramsArray);
				NetOffice.OfficeApi.ColorFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.ColorFormat;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ForeColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoPatternType Pattern
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Pattern", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoPatternType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Pattern", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoLineStyle Style
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Style", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoLineStyle)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Style", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public Single Transparency
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Transparency", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Transparency", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoTriState Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF09 OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF09","OF10","OF11","OF12","OF14")]
		public Single Weight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Weight", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Weight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public NetOffice.OfficeApi.Enums.MsoTriState InsetPen
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InsetPen", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InsetPen", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}