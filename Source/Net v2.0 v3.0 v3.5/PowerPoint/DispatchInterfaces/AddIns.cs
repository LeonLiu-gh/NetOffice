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
	/// DispatchInterface AddIns SupportByLibrary PP09 PP10 PP11 PP12 PP14 
	///</summary>
	[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
	public class AddIns : Collection
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddIns(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddIns(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddIns(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AddIns()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
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
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
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
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="index">ref object index</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.AddIn Item(ref object index)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray, modifiers);
			NetOffice.PowerPointApi.AddIn newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.AddIn;
			index = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public NetOffice.PowerPointApi.AddIn Add(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.PowerPointApi.AddIn newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.PowerPointApi.AddIn;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="index">ref object index</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public void Remove(ref object index)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray, modifiers);
			index = (object)paramsArray[0];
		}

		#endregion
		#pragma warning restore
	}
}