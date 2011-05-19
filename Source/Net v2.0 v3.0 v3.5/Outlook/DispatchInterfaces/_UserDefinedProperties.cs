//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OutlookApi
{
	///<summary>
	/// DispatchInterface _UserDefinedProperties SupportByLibrary "Outlook", 12,14
	///</summary>
	[SupportByLibrary("Outlook", 12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class _UserDefinedProperties : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _UserDefinedProperties(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _UserDefinedProperties(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _UserDefinedProperties(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public _UserDefinedProperties()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi._Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.OutlookApi._Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.Enums.OlObjectClass Class
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Class", paramsArray);
				return (NetOffice.OutlookApi.Enums.OlObjectClass)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi._NameSpace Session
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Session", paramsArray);
				NetOffice.OutlookApi._NameSpace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OutlookApi._NameSpace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
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
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
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
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("Outlook", 12,14)]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OutlookApi._UserDefinedProperty this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.OutlookApi._UserDefinedProperty newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi._UserDefinedProperty;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">NetOffice.OutlookApi.Enums.OlUserPropertyType Type</param>
		/// <param name="DisplayFormat">optional object DisplayFormat</param>
		/// <param name="Formula">optional object Formula</param>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.UserDefinedProperty Add(string name, NetOffice.OutlookApi.Enums.OlUserPropertyType type, object displayFormat, object formula)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, displayFormat, formula);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.UserDefinedProperty newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.UserDefinedProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">NetOffice.OutlookApi.Enums.OlUserPropertyType Type</param>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.UserDefinedProperty Add(string name, NetOffice.OutlookApi.Enums.OlUserPropertyType type)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.OutlookApi.UserDefinedProperty newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.UserDefinedProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("Outlook", 12,14)]
		public NetOffice.OutlookApi.UserDefinedProperty Find(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "Find", paramsArray);
			NetOffice.OutlookApi.UserDefinedProperty newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OutlookApi.UserDefinedProperty;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("Outlook", 12,14)]
		public void Remove(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 12 14 
		/// </summary>
		[SupportByLibrary("Outlook", 12,14)]
		public void Refresh()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Refresh", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}