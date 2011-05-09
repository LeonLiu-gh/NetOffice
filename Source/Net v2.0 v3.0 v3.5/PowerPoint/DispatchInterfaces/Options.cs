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
	/// DispatchInterface Options SupportByLibrary PP10 PP11 PP12 PP14 
	///</summary>
	[SupportByLibrary("PP10","PP11","PP12","PP14")]
	public class Options : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Options(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Options(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Options(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Options()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState DisplayPasteOptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayPasteOptions", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayPasteOptions", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP12","PP14")]
		public NetOffice.OfficeApi.Enums.MsoTriState DoNotPromptForConvert
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DoNotPromptForConvert", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DoNotPromptForConvert", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public bool ShowCoauthoringMergeChanges
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShowCoauthoringMergeChanges", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShowCoauthoringMergeChanges", paramsArray);
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}