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
	/// DispatchInterface ODSOFilters SupportByLibrary OF10 OF11 OF12 OF14 
	///</summary>
	[SupportByLibrary("OF10","OF11","OF12","OF14")]
	public class ODSOFilters : _IMsoDispObj
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilters(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilters(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilters(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ODSOFilters()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
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
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public COMObject Item(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Column">string Column</param>
		/// <param name="Comparison">NetOffice.OfficeApi.Enums.MsoFilterComparison Comparison</param>
		/// <param name="Conjunction">NetOffice.OfficeApi.Enums.MsoFilterConjunction Conjunction</param>
		/// <param name="bstrCompareTo">string bstrCompareTo</param>
		/// <param name="DeferUpdate">bool DeferUpdate</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public void Add(string column, NetOffice.OfficeApi.Enums.MsoFilterComparison comparison, NetOffice.OfficeApi.Enums.MsoFilterConjunction conjunction, string bstrCompareTo, bool deferUpdate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(column, comparison, conjunction, bstrCompareTo, deferUpdate);
			Invoker.Method(this, "Add", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF10 OF11 OF12 OF14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		/// <param name="DeferUpdate">bool DeferUpdate</param>
		[SupportByLibrary("OF10","OF11","OF12","OF14")]
		public void Delete(Int32 index, bool deferUpdate)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index, deferUpdate);
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}