//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface InlineShape SupportByLibrary WD09 WD10 WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
	public class InlineShape : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public InlineShape(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public InlineShape(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public InlineShape(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public InlineShape()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Borders Borders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Borders", paramsArray);
				NetOffice.WordApi.Borders newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Borders;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Borders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.WordApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.LinkFormat LinkFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LinkFormat", paramsArray);
				NetOffice.WordApi.LinkFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.LinkFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Field Field
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Field", paramsArray);
				NetOffice.WordApi.Field newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Field;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.OLEFormat OLEFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OLEFormat", paramsArray);
				NetOffice.WordApi.OLEFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.OLEFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdInlineShapeType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.WordApi.Enums.WdInlineShapeType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Hyperlink Hyperlink
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hyperlink", paramsArray);
				NetOffice.WordApi.Hyperlink newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Hyperlink;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Single Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Height", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Single Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Width", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Single ScaleHeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScaleHeight", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ScaleHeight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Single ScaleWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScaleWidth", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ScaleWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.OfficeApi.Enums.MsoTriState LockAspectRatio
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockAspectRatio", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockAspectRatio", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.LineFormat Line
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Line", paramsArray);
				NetOffice.WordApi.LineFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.LineFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.FillFormat Fill
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fill", paramsArray);
				NetOffice.WordApi.FillFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.FillFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.PictureFormat PictureFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PictureFormat", paramsArray);
				NetOffice.WordApi.PictureFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.PictureFormat;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PictureFormat", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.HorizontalLineFormat HorizontalLineFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HorizontalLineFormat", paramsArray);
				NetOffice.WordApi.HorizontalLineFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.HorizontalLineFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.OfficeApi.Script Script
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Script", paramsArray);
				NetOffice.OfficeApi.Script newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.Script;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 OWSAnchor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OWSAnchor", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.TextEffectFormat TextEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextEffect", paramsArray);
				NetOffice.WordApi.TextEffectFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.TextEffectFormat;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TextEffect", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public string AlternativeText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AlternativeText", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AlternativeText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public bool IsPictureBullet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IsPictureBullet", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public NetOffice.WordApi.GroupShapes GroupItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GroupItems", paramsArray);
				NetOffice.WordApi.GroupShapes newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.GroupShapes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public NetOffice.OfficeApi.Enums.MsoTriState HasChart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasChart", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 
		/// </summary>
		[SupportByLibrary("WD12")]
		public bool Dummy1
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Dummy1", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public NetOffice.WordApi.SoftEdgeFormat SoftEdge
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SoftEdge", paramsArray);
				NetOffice.WordApi.SoftEdgeFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.SoftEdgeFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public NetOffice.WordApi.GlowFormat Glow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Glow", paramsArray);
				NetOffice.WordApi.GlowFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.GlowFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public NetOffice.WordApi.ReflectionFormat Reflection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Reflection", paramsArray);
				NetOffice.WordApi.ReflectionFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.ReflectionFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD12","WD14")]
		public NetOffice.WordApi.ShadowFormat Shadow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shadow", paramsArray);
				NetOffice.WordApi.ShadowFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.ShadowFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public NetOffice.WordApi.Chart Chart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Chart", paramsArray);
				NetOffice.WordApi.Chart newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Chart;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public NetOffice.OfficeApi.Enums.MsoTriState HasSmartArt
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasSmartArt", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public NetOffice.OfficeApi.SmartArt SmartArt
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartArt", paramsArray);
				NetOffice.OfficeApi.SmartArt newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.SmartArt;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public string Title
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Title", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Title", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public Int32 AnchorID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AnchorID", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public Int32 EditID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EditID", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void Activate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Activate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void Reset()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Reset", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void Select()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Select", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Shape ConvertToShape()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ConvertToShape", paramsArray);
			NetOffice.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Shape;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}