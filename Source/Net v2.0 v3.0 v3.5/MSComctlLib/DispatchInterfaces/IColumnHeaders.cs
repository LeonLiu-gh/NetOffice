//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.MSComctlLibApi
{
	///<summary>
	/// DispatchInterface IColumnHeaders SupportByLibrary WCC6.0 
	///</summary>
	[SupportByLibrary("WCC6.0")]
	public class IColumnHeaders : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IColumnHeaders(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IColumnHeaders(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IColumnHeaders(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IColumnHeaders()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Count", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		/// <param name="Index">ref object Index</param>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IColumnHeader get_ControlDefault(ref object index)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "ControlDefault", paramsArray, modifiers);
			NetOffice.MSComctlLibApi.IColumnHeader newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IColumnHeader;
			index = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		/// <param name="Index">ref object Index</param>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IColumnHeader get_Item(ref object index)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray, modifiers);
			NetOffice.MSComctlLibApi.IColumnHeader newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.MSComctlLibApi.IColumnHeader;
			index = (object)paramsArray[0];
			return newObject;
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		/// <param name="Index">ref optional object Index</param>
		/// <param name="Key">ref optional object Key</param>
		/// <param name="Text">ref optional object Text</param>
		/// <param name="Width">ref optional object Width</param>
		/// <param name="Alignment">ref optional object Alignment</param>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IColumnHeader Add_PreVB98(ref object index, ref object key, ref object text, ref object width, ref object alignment)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(index, key, text, width, alignment);
			object returnItem = Invoker.MethodReturn(this, "Add_PreVB98", paramsArray, modifiers);
			NetOffice.MSComctlLibApi.IColumnHeader newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.IColumnHeader;
			index = (object)paramsArray[0];
			key = (object)paramsArray[1];
			text = (object)paramsArray[2];
			width = (object)paramsArray[3];
			alignment = (object)paramsArray[4];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IColumnHeader Add_PreVB98()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add_PreVB98", paramsArray);
			NetOffice.MSComctlLibApi.IColumnHeader newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.IColumnHeader;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public void Clear()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Clear", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		/// <param name="Index">ref object Index</param>
		[SupportByLibrary("WCC6.0")]
		public void Remove(ref object index)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Remove", paramsArray, modifiers);
			index = (object)paramsArray[0];
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		/// <param name="Index">ref optional object Index</param>
		/// <param name="Key">ref optional object Key</param>
		/// <param name="Text">ref optional object Text</param>
		/// <param name="Width">ref optional object Width</param>
		/// <param name="Alignment">ref optional object Alignment</param>
		/// <param name="Icon">ref optional object Icon</param>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IColumnHeader Add(ref object index, ref object key, ref object text, ref object width, ref object alignment, ref object icon)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(index, key, text, width, alignment, icon);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray, modifiers);
			NetOffice.MSComctlLibApi.IColumnHeader newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.IColumnHeader;
			index = (object)paramsArray[0];
			key = (object)paramsArray[1];
			text = (object)paramsArray[2];
			width = (object)paramsArray[3];
			alignment = (object)paramsArray[4];
			icon = (object)paramsArray[5];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WCC6.0 
		/// </summary>
		[SupportByLibrary("WCC6.0")]
		public NetOffice.MSComctlLibApi.IColumnHeader Add()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.MSComctlLibApi.IColumnHeader newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.MSComctlLibApi.IColumnHeader;
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("WCC6.0")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.MethodReturn(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}