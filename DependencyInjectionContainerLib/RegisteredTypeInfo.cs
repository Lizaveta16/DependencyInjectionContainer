﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionContainerLib
{
    class RegisteredTypeInfo
    {
        public LifecycleType Lifecycle { get; }
        public Type InterfaceType { get; }
        public Type ImplementationType { get; }
        public object Instance { get; set; }

        public RegisteredTypeInfo(Type interfaceType, Type implementationType, LifecycleType lifecycle)
        {
            Lifecycle = lifecycle;
            ImplementationType = implementationType;
            InterfaceType = interfaceType;
            Instance = null;
        }
    }

    public enum LifecycleType
    {
        Singleton, InstancePerDependency
    }
}
}
