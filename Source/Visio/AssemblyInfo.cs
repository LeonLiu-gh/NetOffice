﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NetOffice;
using NetOffice.Attributes;

/*
    Contains the following Type Libraries:
	Name - Description - SupportByVersion
	Visio - <NoDescription> - 11
	Visio - <NoDescription> - 12
	Visio - <NoDescription> - 14
	Visio - <NoDescription> - 15
    Visio - <NoDescription> - 16
*/

[assembly: PrimaryInteropAssembly(1, 0)]
[assembly: ImportedFromTypeLib("Visio")]
[assembly: Guid("00021A98-0000-0000-C000-000000000046")]
[assembly: NetOfficeAssemblyAttribute("2.0.0.0")]
[assembly: Dependency("NetOffice.dll", LoadHint.Default)]


/*
Alias Table
 
*/