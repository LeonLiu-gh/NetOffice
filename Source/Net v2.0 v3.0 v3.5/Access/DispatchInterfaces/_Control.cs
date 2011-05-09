//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.AccessApi
{
	///<summary>
	/// DispatchInterface _Control SupportByLibrary AC09 AC10 AC11 AC12 AC14 
	///</summary>
	[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
	public class _Control : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Control(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Control(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Control(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _Control()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public NetOffice.AccessApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.AccessApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
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
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		/// <param name="Row">optional object Row</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public object get_Column(Int32 index, object row)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, row);
			object returnItem = Invoker.PropertyGet(this, "Column", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public object get_Column(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Column", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="lRow">Int32 lRow</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public Int32 get_Selected(Int32 lRow)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lRow);
			object returnItem = Invoker.PropertyGet(this, "Selected", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="lRow">Int32 lRow</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void set_Selected(Int32 lRow, Int32 value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(lRow);
			Invoker.PropertySet(this, "Selected", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public object OldValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OldValue", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public NetOffice.AccessApi.Form Form
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Form", paramsArray);
				NetOffice.AccessApi.Form newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.Form;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public NetOffice.AccessApi.Report Report
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Report", paramsArray);
				NetOffice.AccessApi.Report newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.Report;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public object get_ItemData(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "ItemData", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public COMObject Object
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Object", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public string get_ObjectVerbs(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "ObjectVerbs", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public NetOffice.AccessApi.Properties Properties
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Properties", paramsArray);
				NetOffice.AccessApi.Properties newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.Properties;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public NetOffice.AccessApi._ItemsSelected ItemsSelected
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ItemsSelected", paramsArray);
				NetOffice.AccessApi._ItemsSelected newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi._ItemsSelected;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public NetOffice.AccessApi.Pages Pages
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Pages", paramsArray);
				NetOffice.AccessApi.Pages newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.Pages;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public NetOffice.AccessApi.Children Controls
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Controls", paramsArray);
				NetOffice.AccessApi.Children newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi.Children;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public NetOffice.AccessApi._Hyperlink Hyperlink
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Hyperlink", paramsArray);
				NetOffice.AccessApi._Hyperlink newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi._Hyperlink;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC11","AC12","AC14")]
		public NetOffice.AccessApi._SmartTags SmartTags
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SmartTags", paramsArray);
				NetOffice.AccessApi._SmartTags newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.AccessApi._SmartTags;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public NetOffice.AccessApi.Enums.AcLayoutType Layout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Layout", paramsArray);
				return (NetOffice.AccessApi.Enums.AcLayoutType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public Int16 LeftPadding
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LeftPadding", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LeftPadding", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public Int16 TopPadding
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TopPadding", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TopPadding", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public Int16 RightPadding
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RightPadding", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RightPadding", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public Int16 BottomPadding
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BottomPadding", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BottomPadding", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public byte GridlineStyleLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GridlineStyleLeft", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GridlineStyleLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public byte GridlineStyleTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GridlineStyleTop", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GridlineStyleTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public byte GridlineStyleRight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GridlineStyleRight", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GridlineStyleRight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public byte GridlineStyleBottom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GridlineStyleBottom", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GridlineStyleBottom", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public byte GridlineWidthLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GridlineWidthLeft", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GridlineWidthLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public byte GridlineWidthTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GridlineWidthTop", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GridlineWidthTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public byte GridlineWidthRight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GridlineWidthRight", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GridlineWidthRight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public byte GridlineWidthBottom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GridlineWidthBottom", paramsArray);
				return (byte)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GridlineWidthBottom", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public Int32 GridlineColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GridlineColor", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "GridlineColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public NetOffice.AccessApi.Enums.AcHorizontalAnchor HorizontalAnchor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HorizontalAnchor", paramsArray);
				return (NetOffice.AccessApi.Enums.AcHorizontalAnchor)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "HorizontalAnchor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public NetOffice.AccessApi.Enums.AcVerticalAnchor VerticalAnchor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "VerticalAnchor", paramsArray);
				return (NetOffice.AccessApi.Enums.AcVerticalAnchor)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "VerticalAnchor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public Int32 LayoutID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LayoutID", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public string _Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "_Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "_Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC12","AC14")]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void Undo()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Undo", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void Dropdown()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Dropdown", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void Requery()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Requery", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void SizeToFit()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SizeToFit", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void Goto()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Goto", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public void SetFocus()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetFocus", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="bstrExpr">string bstrExpr</param>
		/// <param name="ppsa">ref optional object[] ppsa</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public object _Evaluate(string bstrExpr, ref object[] ppsa)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true);
			object[] paramsArray = Invoker.ValidateParamsArray(bstrExpr, (object)ppsa);
			object returnItem = Invoker.MethodReturn(this, "_Evaluate", paramsArray, modifiers);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				ppsa = (object[])paramsArray[1];
			return newObject;
			}
			else
			{
				ppsa = (object[])paramsArray[1];
			return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary AC09 AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="bstrExpr">string bstrExpr</param>
		[SupportByLibrary("AC09","AC10","AC11","AC12","AC14")]
		public object _Evaluate(string bstrExpr)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrExpr);
			object returnItem = Invoker.MethodReturn(this, "_Evaluate", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Left">object Left</param>
		/// <param name="Top">optional object Top</param>
		/// <param name="Width">optional object Width</param>
		/// <param name="Height">optional object Height</param>
		[SupportByLibrary("AC10","AC11","AC12","AC14")]
		public void Move(object left, object top, object width, object height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left, top, width, height);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC10 AC11 AC12 AC14 
		/// </summary>
		/// <param name="Left">object Left</param>
		[SupportByLibrary("AC10","AC11","AC12","AC14")]
		public void Move(object left)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(left);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary AC11 AC12 AC14 
		/// </summary>
		/// <param name="dispid">Int32 dispid</param>
		[SupportByLibrary("AC11","AC12","AC14")]
		public bool IsMemberSafe(Int32 dispid)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dispid);
			object returnItem = Invoker.MethodReturn(this, "IsMemberSafe", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}