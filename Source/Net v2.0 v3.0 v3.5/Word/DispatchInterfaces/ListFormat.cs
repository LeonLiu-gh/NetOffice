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
	/// DispatchInterface ListFormat SupportByLibrary WD09 WD10 WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
	public class ListFormat : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListFormat(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListFormat(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListFormat(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ListFormat()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 ListLevelNumber
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListLevelNumber", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ListLevelNumber", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.List List
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "List", paramsArray);
				NetOffice.WordApi.List newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.List;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.ListTemplate ListTemplate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListTemplate", paramsArray);
				NetOffice.WordApi.ListTemplate newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.ListTemplate;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 ListValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListValue", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool SingleList
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SingleList", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool SingleListTemplate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SingleListTemplate", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdListType ListType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListType", paramsArray);
				return (NetOffice.WordApi.Enums.WdListType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public string ListString
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListString", paramsArray);
				return (string)returnItem;
			}
		}

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
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.InlineShape ListPictureBullet
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ListPictureBullet", paramsArray);
				NetOffice.WordApi.InlineShape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.InlineShape;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdContinue CanContinuePreviousList(NetOffice.WordApi.ListTemplate listTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate);
			object returnItem = Invoker.MethodReturn(this, "CanContinuePreviousList", paramsArray);
			return (NetOffice.WordApi.Enums.WdContinue)returnItem;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="NumberType">ref optional object NumberType</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void RemoveNumbers(ref object numberType)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(numberType);
			Invoker.Method(this, "RemoveNumbers", paramsArray, modifiers);
			numberType = (object)paramsArray[0];
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void RemoveNumbers()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "RemoveNumbers", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="NumberType">ref optional object NumberType</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ConvertNumbersToText(ref object numberType)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(numberType);
			Invoker.Method(this, "ConvertNumbersToText", paramsArray, modifiers);
			numberType = (object)paramsArray[0];
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ConvertNumbersToText()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ConvertNumbersToText", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="NumberType">ref optional object NumberType</param>
		/// <param name="Level">ref optional object Level</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 CountNumberedItems(ref object numberType, ref object level)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(numberType, level);
			object returnItem = Invoker.MethodReturn(this, "CountNumberedItems", paramsArray);
			numberType = (object)paramsArray[0];
			level = (object)paramsArray[1];
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 CountNumberedItems()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CountNumberedItems", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyBulletDefaultOld()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyBulletDefaultOld", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyNumberDefaultOld()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyNumberDefaultOld", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyOutlineNumberDefaultOld()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyOutlineNumberDefaultOld", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="ContinuePreviousList">ref optional object ContinuePreviousList</param>
		/// <param name="ApplyTo">ref optional object ApplyTo</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyListTemplateOld(NetOffice.WordApi.ListTemplate listTemplate, ref object continuePreviousList, ref object applyTo)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList, applyTo);
			Invoker.Method(this, "ApplyListTemplateOld", paramsArray, modifiers);
			continuePreviousList = (object)paramsArray[1];
			applyTo = (object)paramsArray[2];
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyListTemplateOld(NetOffice.WordApi.ListTemplate listTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate);
			Invoker.Method(this, "ApplyListTemplateOld", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ListOutdent()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ListOutdent", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ListIndent()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ListIndent", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="DefaultListBehavior">ref optional object DefaultListBehavior</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyBulletDefault(ref object defaultListBehavior)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(defaultListBehavior);
			Invoker.Method(this, "ApplyBulletDefault", paramsArray, modifiers);
			defaultListBehavior = (object)paramsArray[0];
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyBulletDefault()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyBulletDefault", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="DefaultListBehavior">ref optional object DefaultListBehavior</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyNumberDefault(ref object defaultListBehavior)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(defaultListBehavior);
			Invoker.Method(this, "ApplyNumberDefault", paramsArray, modifiers);
			defaultListBehavior = (object)paramsArray[0];
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyNumberDefault()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyNumberDefault", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="DefaultListBehavior">ref optional object DefaultListBehavior</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyOutlineNumberDefault(ref object defaultListBehavior)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(defaultListBehavior);
			Invoker.Method(this, "ApplyOutlineNumberDefault", paramsArray, modifiers);
			defaultListBehavior = (object)paramsArray[0];
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyOutlineNumberDefault()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyOutlineNumberDefault", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="ContinuePreviousList">ref optional object ContinuePreviousList</param>
		/// <param name="ApplyTo">ref optional object ApplyTo</param>
		/// <param name="DefaultListBehavior">ref optional object DefaultListBehavior</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyListTemplate(NetOffice.WordApi.ListTemplate listTemplate, ref object continuePreviousList, ref object applyTo, ref object defaultListBehavior)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList, applyTo, defaultListBehavior);
			Invoker.Method(this, "ApplyListTemplate", paramsArray, modifiers);
			continuePreviousList = (object)paramsArray[1];
			applyTo = (object)paramsArray[2];
			defaultListBehavior = (object)paramsArray[3];
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyListTemplate(NetOffice.WordApi.ListTemplate listTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate);
			Invoker.Method(this, "ApplyListTemplate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		/// <param name="ContinuePreviousList">ref optional object ContinuePreviousList</param>
		/// <param name="ApplyTo">ref optional object ApplyTo</param>
		/// <param name="DefaultListBehavior">ref optional object DefaultListBehavior</param>
		/// <param name="ApplyLevel">ref optional object ApplyLevel</param>
		[SupportByLibrary("WD12","WD14")]
		public void ApplyListTemplateWithLevel(NetOffice.WordApi.ListTemplate listTemplate, ref object continuePreviousList, ref object applyTo, ref object defaultListBehavior, ref object applyLevel)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate, continuePreviousList, applyTo, defaultListBehavior, applyLevel);
			Invoker.Method(this, "ApplyListTemplateWithLevel", paramsArray, modifiers);
			continuePreviousList = (object)paramsArray[1];
			applyTo = (object)paramsArray[2];
			defaultListBehavior = (object)paramsArray[3];
			applyLevel = (object)paramsArray[4];
		}

		/// <summary>
		/// SupportByLibrary WD12 WD14 
		/// </summary>
		/// <param name="ListTemplate">NetOffice.WordApi.ListTemplate ListTemplate</param>
		[SupportByLibrary("WD12","WD14")]
		public void ApplyListTemplateWithLevel(NetOffice.WordApi.ListTemplate listTemplate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(listTemplate);
			Invoker.Method(this, "ApplyListTemplateWithLevel", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}