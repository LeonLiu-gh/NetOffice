//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IPivotCell SupportByLibrary XL10 XL11 XL12 XL14 
	///</summary>
	[SupportByLibrary("XL10","XL11","XL12","XL14")]
	public class IPivotCell : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCell(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCell(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCell(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPivotCell()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
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
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
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
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
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
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Enums.XlPivotCellType PivotCellType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotCellType", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlPivotCellType)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.PivotTable PivotTable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotTable", paramsArray);
				NetOffice.ExcelApi.PivotTable newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.PivotTable;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.PivotField DataField
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataField", paramsArray);
				NetOffice.ExcelApi.PivotField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.PivotField;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.PivotField PivotField
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotField", paramsArray);
				NetOffice.ExcelApi.PivotField newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.PivotField;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.PivotItem PivotItem
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotItem", paramsArray);
				NetOffice.ExcelApi.PivotItem newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.PivotItem;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.PivotItemList RowItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RowItems", paramsArray);
				NetOffice.ExcelApi.PivotItemList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.PivotItemList;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.PivotItemList ColumnItems
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColumnItems", paramsArray);
				NetOffice.ExcelApi.PivotItemList newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.PivotItemList;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Range Range
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Range", paramsArray);
				NetOffice.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Range;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public string Dummy18
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Dummy18", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL10 XL11 XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL10","XL11","XL12","XL14")]
		public NetOffice.ExcelApi.Enums.XlConsolidationFunction CustomSubtotalFunction
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CustomSubtotalFunction", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlConsolidationFunction)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public NetOffice.ExcelApi.PivotLine PivotRowLine
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotRowLine", paramsArray);
				NetOffice.ExcelApi.PivotLine newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.PivotLine;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL12 XL14 
		/// </summary>
		[SupportByLibrary("XL12","XL14")]
		public NetOffice.ExcelApi.PivotLine PivotColumnLine
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PivotColumnLine", paramsArray);
				NetOffice.ExcelApi.PivotLine newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.PivotLine;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public object DataSourceValue
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DataSourceValue", paramsArray);
				Type returnItemType = returnItem.GetType();
				if(true == returnItemType.IsCOMObject)
				{
					COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
					return newObject;
				}
				else
				{
					return  returnItem;
				}
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public NetOffice.ExcelApi.Enums.XlCellChangedState CellChanged
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CellChanged", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlCellChangedState)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public string MDX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MDX", paramsArray);
				return (string)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public Int32 AllocateChange()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "AllocateChange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public Int32 DiscardChange()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "DiscardChange", paramsArray);
			return (Int32)returnItem;
		}

		#endregion
		#pragma warning restore
	}
}