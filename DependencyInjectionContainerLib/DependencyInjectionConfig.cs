using System;
using System.Collections.Generic;

namespace DependencyInjectionContainerLib
{
    public class DependencyInjectionConfig
    {
        private readonly Dictionary<Type, List<RegisteredTypeInfo>> _registeredTypes;

        public DependencyInjectionConfig()
        {
            _registeredTypes = new Dictionary<Type, List<RegisteredTypeInfo>>();
        }

        private void RegisterNewPair(Type _interface, Type _implementation, LifecycleType _lifecycleType = LifecycleType.InstancePerDependency)
        {
            if (!_implementation.IsInterface &&
                !_implementation.IsAbstract &&
                _interface.IsAssignableFrom(_implementation))
            {
                var registeredType = new RegisteredTypeInfo(_interface, _implementation, _lifecycleType);
                if (!_registeredTypes.TryGetValue(_interface, out List<RegisteredTypeInfo> typesAlreadyRegistered))
                {
                    _registeredTypes.Add(_interface, new List<RegisteredTypeInfo>() { registeredType });
                }
                else
                {
                    if (!typesAlreadyRegistered.Contains(registeredType))
                    {
                        typesAlreadyRegistered.Add(registeredType);
                    }
                    else
                    {
                        
                    }
                }
            }
            else
            {
              
            }
        }

        public RegisteredTypeInfo GetImplementation(Type _interface)
        {
            if (_registeredTypes.TryGetValue(_interface, out List<RegisteredTypeInfo> typesAlreadyRegistered))
            {
                return typesAlreadyRegistered.First();
            }
            else
            {
                return null;
            }
        }
    }
}
