//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface SectionProperties SupportByLibrary PP14 
	///</summary>
	[SupportByLibrary("PP14")]
	public class SectionProperties : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SectionProperties(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SectionProperties(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SectionProperties(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public SectionProperties()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
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
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="sectionIndex">Int32 sectionIndex</param>
		[SupportByLibrary("PP14")]
		public string Name(Int32 sectionIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sectionIndex);
			object returnItem = Invoker.MethodReturn(this, "Name", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="sectionIndex">Int32 sectionIndex</param>
		/// <param name="sectionName">string sectionName</param>
		[SupportByLibrary("PP14")]
		public void Rename(Int32 sectionIndex, string sectionName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sectionIndex, sectionName);
			Invoker.Method(this, "Rename", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="sectionIndex">Int32 sectionIndex</param>
		[SupportByLibrary("PP14")]
		public Int32 SlidesCount(Int32 sectionIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sectionIndex);
			object returnItem = Invoker.MethodReturn(this, "SlidesCount", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="sectionIndex">Int32 sectionIndex</param>
		[SupportByLibrary("PP14")]
		public Int32 FirstSlide(Int32 sectionIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sectionIndex);
			object returnItem = Invoker.MethodReturn(this, "FirstSlide", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="SlideIndex">Int32 SlideIndex</param>
		/// <param name="sectionName">string sectionName</param>
		[SupportByLibrary("PP14")]
		public Int32 AddBeforeSlide(Int32 slideIndex, string sectionName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(slideIndex, sectionName);
			object returnItem = Invoker.MethodReturn(this, "AddBeforeSlide", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="sectionIndex">Int32 sectionIndex</param>
		/// <param name="sectionName">optional object sectionName</param>
		[SupportByLibrary("PP14")]
		public Int32 AddSection(Int32 sectionIndex, object sectionName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sectionIndex, sectionName);
			object returnItem = Invoker.MethodReturn(this, "AddSection", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="sectionIndex">Int32 sectionIndex</param>
		[SupportByLibrary("PP14")]
		public Int32 AddSection(Int32 sectionIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sectionIndex);
			object returnItem = Invoker.MethodReturn(this, "AddSection", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="sectionIndex">Int32 sectionIndex</param>
		/// <param name="toPos">Int32 toPos</param>
		[SupportByLibrary("PP14")]
		public void Move(Int32 sectionIndex, Int32 toPos)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sectionIndex, toPos);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="sectionIndex">Int32 sectionIndex</param>
		/// <param name="deleteSlides">bool deleteSlides</param>
		[SupportByLibrary("PP14")]
		public void Delete(Int32 sectionIndex, bool deleteSlides)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sectionIndex, deleteSlides);
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		/// <param name="sectionIndex">Int32 sectionIndex</param>
		[SupportByLibrary("PP14")]
		public string SectionID(Int32 sectionIndex)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sectionIndex);
			object returnItem = Invoker.MethodReturn(this, "SectionID", paramsArray);
			return (string)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}