﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// IMsoDataLabel
    /// </summary>
    [SyntaxBypass]
    public class IMsoDataLabel_ : COMObject, NetOffice.OfficeApi.IMsoDataLabel_
    {
        #region Ctor

        /// <summary>
        /// Stub Ctor, not indented to use
        /// </summary>
        public IMsoDataLabel_() : base()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="start">optional object start</param>
        /// <param name="length">optional object length</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual NetOffice.OfficeApi.IMsoCharacters get_Characters(object start, object length)
        {
            return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.IMsoCharacters>(this, "Characters", typeof(NetOffice.OfficeApi.IMsoCharacters), start, length);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Alias for get_Characters
        /// </summary>
        /// <param name="start">optional object start</param>
        /// <param name="length">optional object length</param>
        [SupportByVersion("Office", 12, 14, 15, 16), Redirect("get_Characters")]
        public virtual NetOffice.OfficeApi.IMsoCharacters Characters(object start, object length)
        {
            return get_Characters(start, length);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="start">optional object start</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual NetOffice.OfficeApi.IMsoCharacters get_Characters(object start)
        {
            return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.IMsoCharacters>(this, "Characters", typeof(NetOffice.OfficeApi.IMsoCharacters), start);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Alias for get_Characters
        /// </summary>
        /// <param name="start">optional object start</param>
        [SupportByVersion("Office", 12, 14, 15, 16), Redirect("get_Characters")]
        public virtual NetOffice.OfficeApi.IMsoCharacters Characters(object start)
        {
            return get_Characters(start);
        }

        #endregion

        #region Methods

        #endregion
    }

    /// <summary>
    /// Interface IMsoDataLabel 
    /// SupportByVersion Office, 12,14,15,16
    /// </summary>
    [SupportByVersion("Office", 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface)]
    public class IMsoDataLabel : IMsoDataLabel_, NetOffice.OfficeApi.IMsoDataLabel
    {
        #pragma warning disable

        #region Type Information

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
                    _type = typeof(IMsoDataLabel);
                return _type;
            }
        }

        #endregion
      
        #region Ctor

        /// <summary>
        /// Stub Ctor, not indented to use
        /// </summary>
        public IMsoDataLabel() : base()
        {

        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual string Name
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "Name");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.IMsoBorder Border
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.IMsoBorder>(this, "Border", typeof(NetOffice.OfficeApi.IMsoBorder));
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.IMsoInterior Interior
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.IMsoInterior>(this, "Interior", typeof(NetOffice.OfficeApi.IMsoInterior));
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.ChartFillFormat Fill
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.ChartFillFormat>(this, "Fill", typeof(NetOffice.OfficeApi.ChartFillFormat));
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
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
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.IMsoCharacters Characters
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.IMsoCharacters>(this, "Characters", typeof(NetOffice.OfficeApi.IMsoCharacters));
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.ChartFont Font
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.ChartFont>(this, "Font", typeof(NetOffice.OfficeApi.ChartFont));
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
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
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
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
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
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
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
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
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
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
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
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
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
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
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
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
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
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
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual bool AutoText
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "AutoText");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "AutoText", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual string NumberFormat
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteStringPropertyGet(this, "NumberFormat");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "NumberFormat", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual bool NumberFormatLinked
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "NumberFormatLinked");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "NumberFormatLinked", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object NumberFormatLocal
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "NumberFormatLocal");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "NumberFormatLocal", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual bool ShowLegendKey
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ShowLegendKey");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ShowLegendKey", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Type
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Type");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Type", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.XlDataLabelPosition Position
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.XlDataLabelPosition>(this, "Position");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteEnumPropertySet(this, "Position", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual bool ShowSeriesName
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ShowSeriesName");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ShowSeriesName", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual bool ShowCategoryName
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ShowCategoryName");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ShowCategoryName", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual bool ShowValue
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ShowValue");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ShowValue", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual bool ShowPercentage
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ShowPercentage");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ShowPercentage", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual bool ShowBubbleSize
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ShowBubbleSize");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ShowBubbleSize", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Separator
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteVariantPropertyGet(this, "Separator");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteVariantPropertySet(this, "Separator", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.IMsoChartFormat Format
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.IMsoChartFormat>(this, "Format", typeof(NetOffice.OfficeApi.IMsoChartFormat));
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Double Height
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Height");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Height", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16), ProxyResult]
        public virtual object Application
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteReferencePropertyGet(this, "Application");
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Int32 Creator
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteInt32PropertyGet(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Double Width
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "Width");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "Width", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16)]
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
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16)]
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
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16)]
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
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16)]
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

        /// <summary>
        /// SupportByVersion Office 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual Double _Height
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "_Height");
            }
        }

        /// <summary>
        /// SupportByVersion Office 15,16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual Double _Width
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteDoublePropertyGet(this, "_Width");
            }
        }

        /// <summary>
        /// SupportByVersion Office 15,16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 15, 16)]
        public virtual bool ShowRange
        {
            get
            {
                return InvokerService.InvokeInternal.ExecuteBoolPropertyGet(this, "ShowRange");
            }
            set
            {
                InvokerService.InvokeInternal.ExecuteValuePropertySet(this, "ShowRange", value);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Select()
        {
            return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "Select");
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual object Delete()
        {
            return InvokerService.InvokeInternal.ExecuteVariantMethodGet(this, "Delete");
        }

        #endregion

        #pragma warning restore
    }
}
