//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface ISparklineGroups SupportByLibrary XL14 
	///</summary>
	[SupportByLibrary("XL14")]
	public class ISparklineGroups : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISparklineGroups(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISparklineGroups(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISparklineGroups(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISparklineGroups()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public NetOffice.ExcelApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.ExcelApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public NetOffice.ExcelApi.Enums.XlCreator Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCreator)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
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
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
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
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XL14")]
		public NetOffice.ExcelApi.SparklineGroup get_Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.ExcelApi.SparklineGroup newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.SparklineGroup;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("XL14")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("IndexerItem")]
		public NetOffice.ExcelApi.SparklineGroup this[object index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "_Default", paramsArray);
			NetOffice.ExcelApi.SparklineGroup newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.SparklineGroup;
			return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="Type">NetOffice.ExcelApi.Enums.XlSparkType Type</param>
		/// <param name="SourceData">string SourceData</param>
		[SupportByLibrary("XL14")]
		public NetOffice.ExcelApi.SparklineGroup Add(NetOffice.ExcelApi.Enums.XlSparkType type, string sourceData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, sourceData);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			NetOffice.ExcelApi.SparklineGroup newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.ExcelApi.SparklineGroup;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public Int32 Clear()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Clear", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public Int32 ClearGroups()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ClearGroups", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="Location">NetOffice.ExcelApi.Range Location</param>
		[SupportByLibrary("XL14")]
		public Int32 Group(NetOffice.ExcelApi.Range location)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(location);
			object returnItem = Invoker.MethodReturn(this, "Group", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public Int32 Ungroup()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Ungroup", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("XL14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
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