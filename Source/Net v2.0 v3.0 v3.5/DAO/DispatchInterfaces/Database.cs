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
	/// DispatchInterface Database SupportByLibrary "DAO", 6,12
	///</summary>
	[SupportByLibrary("DAO", 6,12)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Database : _DAO
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Database(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Database(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Database(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Database()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 CollatingOrder
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CollatingOrder", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string Connect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Connect", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Connect", paramsArray);
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
		public Int16 QueryTimeout
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "QueryTimeout", paramsArray);
				return (Int16)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "QueryTimeout", paramsArray);
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
		public string Version
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Version", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 RecordsAffected
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RecordsAffected", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.TableDefs TableDefs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TableDefs", paramsArray);
				NetOffice.DAOApi.TableDefs newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.TableDefs;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.QueryDefs QueryDefs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "QueryDefs", paramsArray);
				NetOffice.DAOApi.QueryDefs newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.QueryDefs;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Relations Relations
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Relations", paramsArray);
				NetOffice.DAOApi.Relations newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Relations;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Containers Containers
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Containers", paramsArray);
				NetOffice.DAOApi.Containers newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Containers;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordsets Recordsets
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Recordsets", paramsArray);
				NetOffice.DAOApi.Recordsets newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.DAOApi.Recordsets;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string ReplicaID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ReplicaID", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public string DesignMasterID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DesignMasterID", paramsArray);
				return (string)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DesignMasterID", paramsArray);
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
		}

		#endregion

		#region Methods

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
		/// <param name="Query">string Query</param>
		/// <param name="Options">optional object Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public void Execute(string query, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(query, options);
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Query">string Query</param>
		[SupportByLibrary("DAO", 6,12)]
		public void Execute(string query)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(query);
			Invoker.Method(this, "Execute", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Options">optional object Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset _30_OpenRecordset(string name, object type, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, options);
			object returnItem = Invoker.MethodReturn(this, "_30_OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset _30_OpenRecordset(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "_30_OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Value">optional object Value</param>
		/// <param name="DDL">optional object DDL</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Property CreateProperty(object name, object type, object value, object dDL)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, value, dDL);
			object returnItem = Invoker.MethodReturn(this, "CreateProperty", paramsArray);
			NetOffice.DAOApi.Property newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Property;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Property CreateProperty()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateProperty", paramsArray);
			NetOffice.DAOApi.Property newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Property;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Table">optional object Table</param>
		/// <param name="ForeignTable">optional object ForeignTable</param>
		/// <param name="Attributes">optional object Attributes</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Relation CreateRelation(object name, object table, object foreignTable, object attributes)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, table, foreignTable, attributes);
			object returnItem = Invoker.MethodReturn(this, "CreateRelation", paramsArray);
			NetOffice.DAOApi.Relation newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Relation;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Relation CreateRelation()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateRelation", paramsArray);
			NetOffice.DAOApi.Relation newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Relation;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="Attributes">optional object Attributes</param>
		/// <param name="SourceTableName">optional object SourceTableName</param>
		/// <param name="Connect">optional object Connect</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.TableDef CreateTableDef(object name, object attributes, object sourceTableName, object connect)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, attributes, sourceTableName, connect);
			object returnItem = Invoker.MethodReturn(this, "CreateTableDef", paramsArray);
			NetOffice.DAOApi.TableDef newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.TableDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.TableDef CreateTableDef()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateTableDef", paramsArray);
			NetOffice.DAOApi.TableDef newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.TableDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void BeginTrans()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "BeginTrans", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Options">Int32 Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public void CommitTrans(Int32 options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(options);
			Invoker.Method(this, "CommitTrans", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public void Rollback()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Rollback", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Options">optional object Options</param>
		/// <param name="Inconsistent">optional object Inconsistent</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset CreateDynaset(string name, object options, object inconsistent)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, options, inconsistent);
			object returnItem = Invoker.MethodReturn(this, "CreateDynaset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset CreateDynaset(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "CreateDynaset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">optional object Name</param>
		/// <param name="SQLText">optional object SQLText</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.QueryDef CreateQueryDef(object name, object sQLText)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, sQLText);
			object returnItem = Invoker.MethodReturn(this, "CreateQueryDef", paramsArray);
			NetOffice.DAOApi.QueryDef newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.QueryDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.QueryDef CreateQueryDef()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "CreateQueryDef", paramsArray);
			NetOffice.DAOApi.QueryDef newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.QueryDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Source">string Source</param>
		/// <param name="Options">optional object Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset CreateSnapshot(string source, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source, options);
			object returnItem = Invoker.MethodReturn(this, "CreateSnapshot", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Source">string Source</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset CreateSnapshot(string source)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(source);
			object returnItem = Invoker.MethodReturn(this, "CreateSnapshot", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("DAO", 6,12)]
		public void DeleteQueryDef(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			Invoker.Method(this, "DeleteQueryDef", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="SQL">string SQL</param>
		[SupportByLibrary("DAO", 6,12)]
		public Int32 ExecuteSQL(string sQL)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(sQL);
			object returnItem = Invoker.MethodReturn(this, "ExecuteSQL", paramsArray);
			return (Int32)returnItem;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset ListFields(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "ListFields", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset ListTables()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ListTables", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.QueryDef OpenQueryDef(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "OpenQueryDef", paramsArray);
			NetOffice.DAOApi.QueryDef newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.QueryDef;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Options">optional object Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenTable(string name, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, options);
			object returnItem = Invoker.MethodReturn(this, "OpenTable", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenTable(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "OpenTable", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="DbPathName">string DbPathName</param>
		/// <param name="ExchangeType">optional object ExchangeType</param>
		[SupportByLibrary("DAO", 6,12)]
		public void Synchronize(string dbPathName, object exchangeType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dbPathName, exchangeType);
			Invoker.Method(this, "Synchronize", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="DbPathName">string DbPathName</param>
		[SupportByLibrary("DAO", 6,12)]
		public void Synchronize(string dbPathName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dbPathName);
			Invoker.Method(this, "Synchronize", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="PathName">string PathName</param>
		/// <param name="Description">string Description</param>
		/// <param name="Options">optional object Options</param>
		[SupportByLibrary("DAO", 6,12)]
		public void MakeReplica(string pathName, string description, object options)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pathName, description, options);
			Invoker.Method(this, "MakeReplica", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="PathName">string PathName</param>
		/// <param name="Description">string Description</param>
		[SupportByLibrary("DAO", 6,12)]
		public void MakeReplica(string pathName, string description)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(pathName, description);
			Invoker.Method(this, "MakeReplica", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="bstrOld">string bstrOld</param>
		/// <param name="bstrNew">string bstrNew</param>
		[SupportByLibrary("DAO", 6,12)]
		public void NewPassword(string bstrOld, string bstrNew)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(bstrOld, bstrNew);
			Invoker.Method(this, "NewPassword", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">string Name</param>
		/// <param name="Type">optional object Type</param>
		/// <param name="Options">optional object Options</param>
		/// <param name="LockEdit">optional object LockEdit</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenRecordset(string name, object type, object options, object lockEdit)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name, type, options, lockEdit);
			object returnItem = Invoker.MethodReturn(this, "OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="Name">string Name</param>
		[SupportByLibrary("DAO", 6,12)]
		public NetOffice.DAOApi.Recordset OpenRecordset(string name)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(name);
			object returnItem = Invoker.MethodReturn(this, "OpenRecordset", paramsArray);
			NetOffice.DAOApi.Recordset newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.DAOApi.Recordset;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary 6 12 
		/// </summary>
		/// <param name="DbPathName">string DbPathName</param>
		[SupportByLibrary("DAO", 6,12)]
		public void PopulatePartial(string dbPathName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(dbPathName);
			Invoker.Method(this, "PopulatePartial", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}