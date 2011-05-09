//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.OWC10Api
{
	///<summary>
	/// DispatchInterface PivotDataAxis SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	public class PivotDataAxis : PivotAxis
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotDataAxis(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotDataAxis(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotDataAxis(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PivotDataAxis()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public NetOffice.OWC10Api.PivotTotals Totals
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Totals", paramsArray);
				NetOffice.OWC10Api.PivotTotals newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OWC10Api.PivotTotals;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Total">NetOffice.OWC10Api.PivotTotal Total</param>
		/// <param name="Before">optional object Before</param>
		[SupportByLibrary("XWC1.0")]
		public void InsertTotal(NetOffice.OWC10Api.PivotTotal total, object before)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(total, before);
			Invoker.Method(this, "InsertTotal", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Total">NetOffice.OWC10Api.PivotTotal Total</param>
		[SupportByLibrary("XWC1.0")]
		public void InsertTotal(NetOffice.OWC10Api.PivotTotal total)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(total);
			Invoker.Method(this, "InsertTotal", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Total">object Total</param>
		[SupportByLibrary("XWC1.0")]
		public void RemoveTotal(object total)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(total);
			Invoker.Method(this, "RemoveTotal", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}