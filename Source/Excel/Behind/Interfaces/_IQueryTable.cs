﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
    /// <summary>
    /// Interface _IQueryTable 
    /// SupportByVersion Excel, 9,10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface)]
    public class _IQueryTable : COMObject, NetOffice.ExcelApi._IQueryTable
    {
        #pragma warning disable

        #region Type Information

        /// <summary>        /// Instance Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_IQueryTable);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public _IQueryTable() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Application Application
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string Name
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Name");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Name", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool FieldNames
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "FieldNames");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "FieldNames", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool RowNumbers
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "RowNumbers");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "RowNumbers", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool FillAdjacentFormulas
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "FillAdjacentFormulas");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "FillAdjacentFormulas", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual bool HasAutoFormat
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "HasAutoFormat");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "HasAutoFormat", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool RefreshOnFileOpen
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "RefreshOnFileOpen");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "RefreshOnFileOpen", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool Refreshing
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "Refreshing");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool FetchedRowOverflow
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "FetchedRowOverflow");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool BackgroundQuery
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "BackgroundQuery");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "BackgroundQuery", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlCellInsertionMode RefreshStyle
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCellInsertionMode>(this, "RefreshStyle");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "RefreshStyle", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool EnableRefresh
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "EnableRefresh");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnableRefresh", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool SavePassword
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "SavePassword");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SavePassword", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Range Destination
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Range>(this, "Destination", typeof(NetOffice.ExcelApi.Range));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Connection
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Connection");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Connection", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual object Sql
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Sql");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Sql", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string PostText
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "PostText");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "PostText", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Range ResultRange
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Range>(this, "ResultRange", typeof(NetOffice.ExcelApi.Range));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Parameters Parameters
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Parameters>(this, "Parameters", typeof(NetOffice.ExcelApi.Parameters));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Recordset
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Recordset");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteReferencePropertySet(this, "Recordset", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool SaveData
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "SaveData");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SaveData", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual bool TablesOnlyFromHTML
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TablesOnlyFromHTML");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TablesOnlyFromHTML", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool EnableEditing
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "EnableEditing");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "EnableEditing", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlPlatform TextFilePlatform
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlPlatform>(this, "TextFilePlatform");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "TextFilePlatform", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 TextFileStartRow
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "TextFileStartRow");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileStartRow", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlTextParsingType TextFileParseType
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlTextParsingType>(this, "TextFileParseType");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "TextFileParseType", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlTextQualifier TextFileTextQualifier
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlTextQualifier>(this, "TextFileTextQualifier");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "TextFileTextQualifier", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFileConsecutiveDelimiter
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileConsecutiveDelimiter");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileConsecutiveDelimiter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFileTabDelimiter
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileTabDelimiter");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileTabDelimiter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFileSemicolonDelimiter
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileSemicolonDelimiter");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileSemicolonDelimiter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFileCommaDelimiter
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileCommaDelimiter");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileCommaDelimiter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFileSpaceDelimiter
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileSpaceDelimiter");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileSpaceDelimiter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string TextFileOtherDelimiter
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "TextFileOtherDelimiter");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileOtherDelimiter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object TextFileColumnDataTypes
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "TextFileColumnDataTypes");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "TextFileColumnDataTypes", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object TextFileFixedColumnWidths
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "TextFileFixedColumnWidths");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "TextFileFixedColumnWidths", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool PreserveColumnInfo
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "PreserveColumnInfo");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "PreserveColumnInfo", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool PreserveFormatting
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "PreserveFormatting");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "PreserveFormatting", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool AdjustColumnWidth
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "AdjustColumnWidth");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "AdjustColumnWidth", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object CommandText
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "CommandText");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "CommandText", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlCmdType CommandType
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCmdType>(this, "CommandType");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "CommandType", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFilePromptOnRefresh
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFilePromptOnRefresh");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFilePromptOnRefresh", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.xlQueryType QueryType
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.xlQueryType>(this, "QueryType");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool MaintainConnection
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "MaintainConnection");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "MaintainConnection", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string TextFileDecimalSeparator
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "TextFileDecimalSeparator");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileDecimalSeparator", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string TextFileThousandsSeparator
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "TextFileThousandsSeparator");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileThousandsSeparator", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 RefreshPeriod
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "RefreshPeriod");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "RefreshPeriod", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.xlWebSelectionType WebSelectionType
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.xlWebSelectionType>(this, "WebSelectionType");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "WebSelectionType", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.xlWebFormatting WebFormatting
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.xlWebFormatting>(this, "WebFormatting");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "WebFormatting", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string WebTables
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "WebTables");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "WebTables", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool WebPreFormattedTextToColumns
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "WebPreFormattedTextToColumns");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "WebPreFormattedTextToColumns", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool WebSingleBlockTextImport
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "WebSingleBlockTextImport");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "WebSingleBlockTextImport", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool WebDisableDateRecognition
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "WebDisableDateRecognition");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "WebDisableDateRecognition", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool WebConsecutiveDelimitersAsOne
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "WebConsecutiveDelimitersAsOne");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "WebConsecutiveDelimitersAsOne", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual bool WebDisableRedirections
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "WebDisableRedirections");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "WebDisableRedirections", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual object EditWebPage
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "EditWebPage");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "EditWebPage", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual string SourceConnectionFile
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "SourceConnectionFile");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SourceConnectionFile", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual string SourceDataFile
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "SourceDataFile");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "SourceDataFile", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlRobustConnect RobustConnect
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlRobustConnect>(this, "RobustConnect");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "RobustConnect", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFileTrailingMinusNumbers
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "TextFileTrailingMinusNumbers");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "TextFileTrailingMinusNumbers", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.ListObject ListObject
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ListObject>(this, "ListObject", typeof(NetOffice.ExcelApi.ListObject));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlTextVisualLayoutType TextFileVisualLayout
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlTextVisualLayoutType>(this, "TextFileVisualLayout");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "TextFileVisualLayout", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.WorkbookConnection WorkbookConnection
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.WorkbookConnection>(this, "WorkbookConnection", typeof(NetOffice.ExcelApi.WorkbookConnection));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Sort Sort
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Sort>(this, "Sort", typeof(NetOffice.ExcelApi.Sort));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 CancelRefresh()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "CancelRefresh");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Delete()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "Delete");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="backgroundQuery">optional object backgroundQuery</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool Refresh(object backgroundQuery)
        {
            return InvokerService.InvokeInternal.ExecuteBoolMethodGet(this, "Refresh", backgroundQuery);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool Refresh()
        {
            return InvokerService.InvokeInternal.ExecuteBoolMethodGet(this, "Refresh");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 ResetTimer()
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "ResetTimer");
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="oDCFileName">string oDCFileName</param>
        /// <param name="description">optional object description</param>
        /// <param name="keywords">optional object keywords</param>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAsODC(string oDCFileName, object description, object keywords)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAsODC", oDCFileName, description, keywords);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="oDCFileName">string oDCFileName</param>
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAsODC(string oDCFileName)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAsODC", oDCFileName);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="oDCFileName">string oDCFileName</param>
        /// <param name="description">optional object description</param>
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAsODC(string oDCFileName, object description)
        {
            return InvokerService.InvokeInternal.ExecuteInt32MethodGet(this, "SaveAsODC", oDCFileName, description);
        }

        #endregion

        #pragma warning restore
    }
}

