using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionContainerLib
{
    class ConfiguredTypeInfo
    {
        public bool IsSingleton { get; set; }

        public Type GetImplementationInterface { get; }

        public Type GetImplementation { get; }

        public object GetInstance { get; set; }

        public ConfiguredTypeInfo(Type impl, Type interf, bool isSingleton = false)
        {
            IsSingleton = isSingleton;
            GetImplementation = impl;
            GetImplementationInterface = interf;
            GetInstance = null;
        }
    }
}
