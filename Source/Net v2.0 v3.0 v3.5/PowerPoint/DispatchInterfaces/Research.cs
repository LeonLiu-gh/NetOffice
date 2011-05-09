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
	/// DispatchInterface Research SupportByLibrary PP12 PP14 
	///</summary>
	[SupportByLibrary("PP12","PP14")]
	public class Research : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Research()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
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
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
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

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		/// <param name="ServiceID">string ServiceID</param>
		/// <param name="QueryString">ref object QueryString</param>
		/// <param name="QueryLanguage">ref object QueryLanguage</param>
		/// <param name="UseSelection">bool UseSelection</param>
		/// <param name="LaunchQuery">bool LaunchQuery</param>
		[SupportByLibrary("PP12","PP14")]
		public void Query(string serviceID, ref object queryString, ref object queryLanguage, bool useSelection, bool launchQuery)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,false,false);
			object[] paramsArray = Invoker.ValidateParamsArray(serviceID, queryString, queryLanguage, useSelection, launchQuery);
			Invoker.Method(this, "Query", paramsArray, modifiers);
			queryString = (object)paramsArray[1];
			queryLanguage = (object)paramsArray[2];
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		/// <param name="Language1">ref object Language1</param>
		/// <param name="Language2">ref object Language2</param>
		[SupportByLibrary("PP12","PP14")]
		public void SetLanguagePair(ref object language1, ref object language2)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(language1, language2);
			Invoker.Method(this, "SetLanguagePair", paramsArray, modifiers);
			language1 = (object)paramsArray[0];
			language2 = (object)paramsArray[1];
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		/// <param name="ServiceID">string ServiceID</param>
		[SupportByLibrary("PP12","PP14")]
		public bool IsResearchService(string serviceID)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(serviceID);
			object returnItem = Invoker.MethodReturn(this, "IsResearchService", paramsArray);
			return (bool)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}