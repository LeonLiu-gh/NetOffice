﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NetOffice
{
    /// <summary>
    /// NetOffice wrap all thrown exceptions from Office applications in a COMException.
    /// This enum can be used to set the exception message
    /// </summary>
    public enum ExceptionMessageHandling
    {
        /// <summary>
        /// The standard message from NetOffice.Settings.ExceptionMessage.
        /// </summary>
        Default = 0,

        /// <summary>
        /// The message from the source exception.
        /// </summary>
        CopyInnerExceptionMessageToTopLevelException = 1,

        /// <summary>
        /// All inner exception messages as a summary.
        /// </summary>
        CopyAllInnerExceptionMessagesToTopLevelException = 2,

        /// <summary>
        /// The standard message from NetOffice.Settings.ExceptionDiagnosticMessage.
        /// NetOffice want replace placeholders(if exists) in that string as follows:
        /// {CallType}              - Call Type as method or property
        /// {CallInstance}          - ICOMObject InstanceFriendlyName
        /// {Name}                  - Name of the method or property
        /// {Args}                  - Given Arguments
        /// {ParenthesizedArgs}     - Given Arguments, parenthesized if one or more argument exists
        /// {NewLine}               - New line
        /// {ApplicationVersion}    - Loaded Office Applications in its version
        /// {NlApplicationVersion}  - New line and loaded Office Applications in its version. New line only when one or more application is available
        /// </summary>
        Diagnostics = 3,

        /// <summary>
        /// The standard message from NetOffice.Settings.ExceptionDiagnosticMessage followed by the most inner exception message.
        /// NetOffice want replace placeholders(if exists) in that string as follows:
        /// {CallType}              - Call Type as method or property
        /// {CallInstance}          - ICOMObject InstanceFriendlyName
        /// {Name}                  - Name of the method or property
        /// {Args}                  - Given Arguments
        /// {ParenthesizedArgs}     - Given Arguments, parenthesized if one or more argument exists
        /// {NewLine}               - New line
        /// {ApplicationVersion}    - Loaded Office Applications in its version
        /// {NlApplicationVersion}  - New line and loaded Office Applications in its version. New line only when one or more application is available
        /// </summary>
        DiagnosticsAndInnerMessage = 4
    }
}