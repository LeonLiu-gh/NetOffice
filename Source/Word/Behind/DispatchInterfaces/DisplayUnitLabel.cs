﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.WordApi.Behind
{
    /// <summary>
    /// DisplayUnitLabel
    /// </summary>
    [SyntaxBypass]
    public class DisplayUnitLabel_ : COMObject, NetOffice.WordApi.DisplayUnitLabel_
    {
        #region Ctor

        /// <summary>
        /// Stub Ctor, not indented to use
        /// </summary>
        public DisplayUnitLabel_() : base()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="start">optional object start</param>
        /// <param name="length">optional object length</param>
        /// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834557.aspx
        [SupportByVersion("Word", 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual NetOffice.WordApi.ChartCharacters get_Characters(object start, object length)
        {
            return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.ChartCharacters>(this, "Characters", typeof(NetOffice.WordApi.ChartCharacters), start, length);
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Alias for get_Characters
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834557.aspx </remarks>
        /// <param name="start">optional object start</param>
        /// <param name="length">optional object length</param>
        [SupportByVersion("Word", 14, 15, 16), Redirect("get_Characters")]
        public virtual NetOffice.WordApi.ChartCharacters Characters(object start, object length)
        {
            return get_Characters(start, length);
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="start">optional object start</param>
        /// MSDN Online Documentation: http://msdn.microsoft.com/en-us/en-us/library/office/ff834557.aspx
        [SupportByVersion("Word", 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual NetOffice.WordApi.ChartCharacters get_Characters(object start)
        {
            return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.ChartCharacters>(this, "Characters", typeof(NetOffice.WordApi.ChartCharacters), start);
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Alias for get_Characters
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834557.aspx </remarks>
        /// <param name="start">optional object start</param>
        [SupportByVersion("Word", 14, 15, 16), Redirect("get_Characters")]
        public virtual NetOffice.WordApi.ChartCharacters Characters(object start)
        {
            return get_Characters(start);
        }

        #endregion

        #region Methods

        #endregion
    }

    /// <summary>
    /// DispatchInterface DisplayUnitLabel 
    /// SupportByVersion Word, 14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834922.aspx </remarks>
    [SupportByVersion("Word", 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class DisplayUnitLabel : DisplayUnitLabel_
    {
        #pragma warning disable

        #region Type Information

        /// <summary>
        /// Contract Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type ContractType
        {
            get
            {
                if(null == _contractType)
                    _contractType = typeof(NetOffice.WordApi.DisplayUnitLabel);
                return _contractType;
            }
        }
        private static Type _contractType;


        /// <summary>
        /// Instance Type
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
                    _type = typeof(DisplayUnitLabel);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Stub Ctor, not indented to use
        /// </summary>
        public DisplayUnitLabel() : base()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195998.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual string Caption
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Caption");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Caption", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff834557.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual NetOffice.WordApi.ChartCharacters Characters
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.ChartCharacters>(this, "Characters", typeof(NetOffice.WordApi.ChartCharacters));
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Word", 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual NetOffice.WordApi.ChartFont Font
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.ChartFont>(this, "Font", typeof(NetOffice.WordApi.ChartFont));
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff197297.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual object HorizontalAlignment
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "HorizontalAlignment");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "HorizontalAlignment", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff840909.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual Double Left
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Left");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Left", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821287.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual object Orientation
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Orientation");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Orientation", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff822566.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual bool Shadow
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "Shadow");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Shadow", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192752.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual string Text
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Text");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Text", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff835986.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual Double Top
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Top");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Top", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff844901.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual object VerticalAlignment
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "VerticalAlignment");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "VerticalAlignment", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845455.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual Int32 ReadingOrder
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "ReadingOrder");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ReadingOrder", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Word", 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual object AutoScaleFont
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "AutoScaleFont");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "AutoScaleFont", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Word", 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual NetOffice.WordApi.Interior Interior
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.Interior>(this, "Interior", typeof(NetOffice.WordApi.Interior));
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Word", 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual NetOffice.WordApi.ChartFillFormat Fill
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.ChartFillFormat>(this, "Fill", typeof(NetOffice.WordApi.ChartFillFormat));
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Word", 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual NetOffice.WordApi.ChartBorder Border
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.ChartBorder>(this, "Border", typeof(NetOffice.WordApi.ChartBorder));
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff195639.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual string Name
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Name");
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff193618.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845083.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual bool IncludeInLayout
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "IncludeInLayout");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "IncludeInLayout", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838726.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual NetOffice.WordApi.Enums.XlChartElementPosition Position
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.WordApi.Enums.XlChartElementPosition>(this, "Position");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "Position", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838285.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual NetOffice.WordApi.ChartFormat Format
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.WordApi.ChartFormat>(this, "Format", typeof(NetOffice.WordApi.ChartFormat));
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff839375.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16), ProxyResult]
        public virtual object Application
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Application");
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff823267.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual Int32 Creator
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff840624.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual Double Height
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Height");
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff838754.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual Double Width
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Width");
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff837723.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual string Formula
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Formula");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Formula", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff196314.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual string FormulaR1C1
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "FormulaR1C1");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "FormulaR1C1", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff192833.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual string FormulaLocal
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "FormulaLocal");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "FormulaLocal", value);
            }
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff845877.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual string FormulaR1C1Local
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "FormulaR1C1Local");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "FormulaR1C1Local", value);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff836401.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual object Delete()
        {
            return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "Delete");
        }

        /// <summary>
        /// SupportByVersion Word 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff821030.aspx </remarks>
        [SupportByVersion("Word", 14, 15, 16)]
        public virtual object Select()
        {
            return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "Select");
        }

        #endregion

        #pragma warning restore
    }
}
