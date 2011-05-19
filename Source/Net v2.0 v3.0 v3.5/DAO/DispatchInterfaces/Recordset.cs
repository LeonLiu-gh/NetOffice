//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.DAOApi
{
	///<summary>
	/// DispatchInterface Recordset SupportByLibrary "DAO", 6,12
	///</summary>
	[SupportByLibrary("DAO", 6,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Recordset : _DAO
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Recordset()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool BOF
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BOF", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public byte[] Bookmark
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = (object)Invoker.PropertyGet(this, "Bookmark", paramsArray);
				return (byte[])returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Bookmark", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool Bookmarkable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Bookmarkable", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public object DateCreated
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DateCreated", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
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
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool EOF
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EOF", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string Filter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Filter", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Filter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Index", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public byte[] LastModified
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = (object)Invoker.PropertyGet(this, "LastModified", paramsArray);
				return (byte[])returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public object LastUpdated
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LastUpdated", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
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
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool LockEdits
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LockEdits", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LockEdits", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool NoMatch
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NoMatch", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string Sort
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Sort", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Sort", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool Transactions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Transactions", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int16 Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (Int16)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 RecordCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecordCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool Updatable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Updatable", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool Restartable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Restartable", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string ValidationText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ValidationText", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string ValidationRule
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ValidationRule", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public byte[] CacheStart
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = (object)Invoker.PropertyGet(this, "CacheStart", paramsArray);
				return (byte[])returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CacheStart", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 CacheSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CacheSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "CacheSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Single PercentPosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PercentPosition", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PercentPosition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 AbsolutePosition
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AbsolutePosition", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AbsolutePosition", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int16 EditMode
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EditMode", paramsArray);
				return (Int16)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 ODBCFetchCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ODBCFetchCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 ODBCFetchDelay
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ODBCFetchDelay", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Database Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				NetOffice.DAOApi.Database newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Database;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Fields Fields
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fields", paramsArray);
				NetOffice.DAOApi.Fields newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Fields;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Indexes Indexes
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Indexes", paramsArray);
				NetOffice.DAOApi.Indexes newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Indexes;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Item">object Item</param>
		[SupportByLibrary("DAO", 6,12)]
		public object get_Collect(object item)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			object returnItem = Invoker.PropertyGet(this, "Collect", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Item">object Item</param>
		[SupportByLibrary("DAO", 6,12)]
		public void set_Collect(object item, object value)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(item);
			Invoker.PropertySet(this, "Collect", paramsArray, value);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 hStmt
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "hStmt", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool StillExecuting
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "StillExecuting", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 BatchSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BatchSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BatchSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 BatchCollisionCount
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BatchCollisionCount", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public object BatchCollisions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BatchCollisions", paramsArray);
				Type returnItemType = Invoker.GetObjectType(returnItem);
				if ((null != returnItemType) && (true == returnItemType.IsCOMObject))
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
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Connection Connection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Connection", paramsArray);
				NetOffice.DAOApi.Connection newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Connection;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Connection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int16 RecordStatus
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecordStatus", paramsArray);
				return (Int16)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 UpdateOptions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "UpdateOptions", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "UpdateOptions", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void _30_CancelUpdate()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "_30_CancelUpdate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void AddNew()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "AddNew", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void Close()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Close", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Type">optional object Type</param>
		/// <param name="Options">optional object Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenRecordset(object type, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, options);
			object returnItem = Invoker.MethodReturn(this, "OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenRecordset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void Edit()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Edit", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Criteria">string Criteria</param>
		[SupportByLibrary("DAO", 6,12)]
		public void FindFirst(string criteria)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(criteria);
			Invoker.Method(this, "FindFirst", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Criteria">string Criteria</param>
		[SupportByLibrary("DAO", 6,12)]
		public void FindLast(string criteria)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(criteria);
			Invoker.Method(this, "FindLast", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Criteria">string Criteria</param>
		[SupportByLibrary("DAO", 6,12)]
		public void FindNext(string criteria)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(criteria);
			Invoker.Method(this, "FindNext", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Criteria">string Criteria</param>
		[SupportByLibrary("DAO", 6,12)]
		public void FindPrevious(string criteria)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(criteria);
			Invoker.Method(this, "FindPrevious", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void MoveFirst()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveFirst", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void _30_MoveLast()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "_30_MoveLast", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void MoveNext()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MoveNext", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void MovePrevious()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "MovePrevious", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Comparison">string Comparison</param>
		/// <param name="Key1">object Key1</param>
		/// <param name="Key2">optional object Key2</param>
		/// <param name="Key3">optional object Key3</param>
		/// <param name="Key4">optional object Key4</param>
		/// <param name="Key5">optional object Key5</param>
		/// <param name="Key6">optional object Key6</param>
		/// <param name="Key7">optional object Key7</param>
		/// <param name="Key8">optional object Key8</param>
		/// <param name="Key9">optional object Key9</param>
		/// <param name="Key10">optional object Key10</param>
		/// <param name="Key11">optional object Key11</param>
		/// <param name="Key12">optional object Key12</param>
		/// <param name="Key13">optional object Key13</param>
		[SupportByLibrary("DAO", 6,12)]
		public void Seek(string comparison, object key1, object key2, object key3, object key4, object key5, object key6, object key7, object key8, object key9, object key10, object key11, object key12, object key13)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(comparison, key1, key2, key3, key4, key5, key6, key7, key8, key9, key10, key11, key12, key13);
			Invoker.Method(this, "Seek", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Comparison">string Comparison</param>
		/// <param name="Key1">object Key1</param>
		[SupportByLibrary("DAO", 6,12)]
		public void Seek(string comparison, object key1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(comparison, key1);
			Invoker.Method(this, "Seek", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void _30_Update()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "_30_Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset Clone()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Clone", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="NewQueryDef">optional object NewQueryDef</param>
		[SupportByLibrary("DAO", 6,12)]
		public void Requery(object newQueryDef)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(newQueryDef);
			Invoker.Method(this, "Requery", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void Requery()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Requery", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Rows">Int32 Rows</param>
		/// <param name="StartBookmark">optional object StartBookmark</param>
		[SupportByLibrary("DAO", 6,12)]
		public void Move(Int32 rows, object startBookmark)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rows, startBookmark);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Rows">Int32 Rows</param>
		[SupportByLibrary("DAO", 6,12)]
		public void Move(Int32 rows)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rows);
			Invoker.Method(this, "Move", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Rows">optional object Rows</param>
		/// <param name="StartBookmark">optional object StartBookmark</param>
		[SupportByLibrary("DAO", 6,12)]
		public void FillCache(object rows, object startBookmark)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(rows, startBookmark);
			Invoker.Method(this, "FillCache", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void FillCache()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "FillCache", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Options">optional object Options</param>
		/// <param name="Inconsistent">optional object Inconsistent</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset CreateDynaset(object options, object inconsistent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(options, inconsistent);
			object returnItem = Invoker.MethodReturn(this, "CreateDynaset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset CreateDynaset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateDynaset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Options">optional object Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset CreateSnapshot(object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(options);
			object returnItem = Invoker.MethodReturn(this, "CreateSnapshot", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset CreateSnapshot()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateSnapshot", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.QueryDef CopyQueryDef()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CopyQueryDef", paramsArray);
			NetOffice.DAOApi.QueryDef newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.QueryDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset ListFields()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ListFields", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset ListIndexes()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ListIndexes", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="NumRows">optional object NumRows</param>
		[SupportByLibrary("DAO", 6,12)]
		public object GetRows(object numRows)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(numRows);
			object returnItem = Invoker.MethodReturn(this, "GetRows", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public object GetRows()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "GetRows", paramsArray);
			Type returnItemType = Invoker.GetObjectType(returnItem);
			if ((null != returnItem) && (true == returnItemType.IsCOMObject))
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void Cancel()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Cancel", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public bool NextRecordset()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "NextRecordset", paramsArray);
			return (bool)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="UpdateType">Int32 UpdateType</param>
		[SupportByLibrary("DAO", 6,12)]
		public void CancelUpdate(Int32 updateType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(updateType);
			Invoker.Method(this, "CancelUpdate", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="UpdateType">Int32 UpdateType</param>
		/// <param name="Force">bool Force</param>
		[SupportByLibrary("DAO", 6,12)]
		public void Update(Int32 updateType, bool force)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(updateType, force);
			Invoker.Method(this, "Update", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public void MoveLast(Int32 options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(options);
			Invoker.Method(this, "MoveLast", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}