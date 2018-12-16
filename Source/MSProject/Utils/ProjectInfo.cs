﻿using System;
using System.Reflection;
using NetOffice;
using NetOffice.Attributes;

namespace MSProjectApi.Utils
{
    #pragma warning disable
    /// <summary>
    /// Necessary factory info, used from NetOffice.Core while Initialize()
    /// </summary>
    public class ProjectInfo : IFactoryInfo
    {
        #region Fields

        private string    _name;
        private string    _namespace     = "NetOffice.MSProjectApi";
        private Guid[]    _componentGuid = new Guid[]{new Guid("A7107640-94DF-1068-855E-00DD01075445")};
        private Assembly  _assembly;
        private NetOfficeAssemblyAttribute _assemblyAttribute;
        private Type[]	  _exportedTypes;
		private string[]  _dependents;
		
        #endregion

        #region Ctor

        public ProjectInfo()
        {
            _assembly = typeof(ProjectInfo).Assembly;
            _assemblyAttribute = _assembly.GetCustomAttributes(typeof(NetOfficeAssemblyAttribute), true)[0] as NetOfficeAssemblyAttribute;
            _name = _assembly.GetName().Name;
        }

        #endregion

        #region IFactoryInfo

        public string AssemblyName
        {
            get
            {
                return _name;
            }
        }

        public string AssemblyNamespace
        {
            get
            {
                return _namespace;
            }
        }

        public Guid[] ComponentGuid
        {
            get
            {
                return _componentGuid;
            }
        }

        public Assembly Assembly
        {
            get
            {
                return _assembly;
            }
        }

        public NetOfficeAssemblyAttribute AssemblyAttribute
        {
            get
            {
                return _assemblyAttribute;
            }
        }

        public string[] Dependencies
        {
            get
            {
				if(null == _dependents)
					_dependents = new string[]{"OfficeApi.dll","VBIDEApi.dll","MSHTMLApi.dll"};
                return _dependents;
            }
        }

        public bool IsDuck
        {
            get
            {
                return false;
            }
        }

        public bool Contains(Type type)
        {
            if (null == _exportedTypes)
                _exportedTypes = Assembly.GetExportedTypes();

            foreach (Type item in _exportedTypes)
            {
                if (item == type)
                    return true;
            }

            return false;
        }

        public bool Contains(string className)
        {
            if (null == _exportedTypes)
                _exportedTypes = Assembly.GetExportedTypes();

            foreach (Type item in _exportedTypes)
            {
                if (item.Name.EndsWith(className, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }

            return false;
        }

        #endregion
    }
    #pragma warning restore
}