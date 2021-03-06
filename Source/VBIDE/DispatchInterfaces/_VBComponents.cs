﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.VBIDEApi
{
    /// <summary>
    /// DispatchInterface _VBComponents
    /// SupportByVersion VBIDE, 12,14,5.3
    /// </summary>
    [SupportByVersion("VBIDE", 12, 14, 5.3)]
    [EntityType(EntityType.IsDispatchInterface), BaseType]
	[TypeId("EEE0091C-E393-11D1-BB03-00C04FB6C4A6")]
    [CoClassSource(typeof(NetOffice.VBIDEApi.VBComponents))]
    public interface _VBComponents : _VBComponents_Old
    {
        #region Methods

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        /// <param name="progId">string progId</param>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        NetOffice.VBIDEApi.VBComponent AddCustom(string progId);

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        /// <param name="index">optional Int32 index = 0</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        NetOffice.VBIDEApi.VBComponent AddMTDesigner(object index);

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        [CustomMethod]
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        NetOffice.VBIDEApi.VBComponent AddMTDesigner();

        #endregion
    }
}
