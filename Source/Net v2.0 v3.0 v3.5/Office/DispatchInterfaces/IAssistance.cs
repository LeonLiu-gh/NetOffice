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
	/// DispatchInterface IAssistance SupportByLibrary OF12 OF14 
	///</summary>
	[SupportByLibrary("OF12","OF14")]
	public class IAssistance : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAssistance(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAssistance(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAssistance(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IAssistance()
		{
		}
		
		#endregion
		
		#region Properties

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="HelpId">string HelpId</param>
		/// <param name="Scope">string Scope</param>
		[SupportByLibrary("OF12","OF14")]
		public void ShowHelp(string helpId, string scope)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpId, scope);
			Invoker.Method(this, "ShowHelp", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="Query">string Query</param>
		/// <param name="Scope">string Scope</param>
		[SupportByLibrary("OF12","OF14")]
		public void SearchHelp(string query, string scope)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(query, scope);
			Invoker.Method(this, "SearchHelp", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="HelpId">string HelpId</param>
		[SupportByLibrary("OF12","OF14")]
		public void SetDefaultContext(string helpId)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpId);
			Invoker.Method(this, "SetDefaultContext", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary OF12 OF14 
		/// </summary>
		/// <param name="HelpId">string HelpId</param>
		[SupportByLibrary("OF12","OF14")]
		public void ClearDefaultContext(string helpId)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(helpId);
			Invoker.Method(this, "ClearDefaultContext", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}