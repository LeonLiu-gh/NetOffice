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
	/// DispatchInterface XMLNamespace SupportByLibrary WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD11","WD12","WD14")]
	public class XMLNamespace : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespace()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
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
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
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
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
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
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public string URI
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "URI", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="AllUsers">bool AllUsers</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public string get_Location(bool allUsers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			object returnItem = Invoker.PropertyGet(this, "Location", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="AllUsers">bool AllUsers</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void set_Location(bool allUsers, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			Invoker.PropertySet(this, "Location", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="AllUsers">bool AllUsers</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public string get_Alias(bool allUsers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			object returnItem = Invoker.PropertyGet(this, "Alias", paramsArray);
			return (string)returnItem;
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="AllUsers">bool AllUsers</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void set_Alias(bool allUsers, string value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			Invoker.PropertySet(this, "Alias", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public NetOffice.WordApi.XSLTransforms XSLTransforms
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "XSLTransforms", paramsArray);
				NetOffice.WordApi.XSLTransforms newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.XSLTransforms;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="AllUsers">bool AllUsers</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public NetOffice.WordApi.XSLTransform get_DefaultTransform(bool allUsers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			object returnItem = Invoker.PropertyGet(this, "DefaultTransform", paramsArray);
			NetOffice.WordApi.XSLTransform newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.XSLTransform;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="AllUsers">bool AllUsers</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void set_DefaultTransform(bool allUsers, NetOffice.WordApi.XSLTransform value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(allUsers);
			Invoker.PropertySet(this, "DefaultTransform", paramsArray, value);
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Document">ref object Document</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void AttachToDocument(ref object document)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(document);
			Invoker.Method(this, "AttachToDocument", paramsArray, modifiers);
			document = (object)paramsArray[0];
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}