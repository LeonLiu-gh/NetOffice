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
	/// Interface ISparklineGroup SupportByLibrary XL14 
	///</summary>
	[SupportByLibrary("XL14")]
	public class ISparklineGroup : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISparklineGroup(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISparklineGroup(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISparklineGroup(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ISparklineGroup()
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
		public NetOffice.ExcelApi.Sparkline get_Item(object index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.ExcelApi.Sparkline newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Sparkline;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public NetOffice.ExcelApi.Range Location
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Location", paramsArray);
				NetOffice.ExcelApi.Range newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.Range;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Location", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public string SourceData
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SourceData", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SourceData", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public string DateRange
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DateRange", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DateRange", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public NetOffice.ExcelApi.Enums.XlSparkType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlSparkType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public NetOffice.ExcelApi.FormatColor SeriesColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SeriesColor", paramsArray);
				NetOffice.ExcelApi.FormatColor newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.FormatColor;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public NetOffice.ExcelApi.SparkPoints Points
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Points", paramsArray);
				NetOffice.ExcelApi.SparkPoints newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.SparkPoints;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public NetOffice.ExcelApi.SparkAxes Axes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Axes", paramsArray);
				NetOffice.ExcelApi.SparkAxes newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.ExcelApi.SparkAxes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public NetOffice.ExcelApi.Enums.XlDisplayBlanksAs DisplayBlanksAs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayBlanksAs", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlDisplayBlanksAs)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayBlanksAs", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public bool DisplayHidden
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DisplayHidden", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DisplayHidden", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public object LineWeight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LineWeight", paramsArray);
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
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LineWeight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public NetOffice.ExcelApi.Enums.XlSparklineRowCol PlotBy
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PlotBy", paramsArray);
				return (NetOffice.ExcelApi.Enums.XlSparklineRowCol)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PlotBy", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="Location">NetOffice.ExcelApi.Range Location</param>
		[SupportByLibrary("XL14")]
		public Int32 ModifyLocation(NetOffice.ExcelApi.Range location)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(location);
			object returnItem = Invoker.MethodReturn(this, "ModifyLocation", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="SourceData">string SourceData</param>
		[SupportByLibrary("XL14")]
		public Int32 ModifySourceData(string sourceData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sourceData);
			object returnItem = Invoker.MethodReturn(this, "ModifySourceData", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="Location">NetOffice.ExcelApi.Range Location</param>
		/// <param name="SourceData">string SourceData</param>
		[SupportByLibrary("XL14")]
		public Int32 Modify(NetOffice.ExcelApi.Range location, string sourceData)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(location, sourceData);
			object returnItem = Invoker.MethodReturn(this, "Modify", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		/// <param name="DateRange">string DateRange</param>
		[SupportByLibrary("XL14")]
		public Int32 ModifyDateRange(string dateRange)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dateRange);
			object returnItem = Invoker.MethodReturn(this, "ModifyDateRange", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary XL14 
		/// </summary>
		[SupportByLibrary("XL14")]
		public Int32 Delete()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Delete", paramsArray);
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