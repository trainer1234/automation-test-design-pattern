using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;
using System.Text;

namespace ATDP.Core.Singleton
{
    public abstract class ThreadSafeNestedConstructorSingleton<T>
    {
        public static T Instance => SingletonFactory.Instance;

        internal static class SingletonFactory
        {
            internal static T Instance;

            static SingletonFactory()
            {
                CreateInstance(typeof(T));
            }

            public static T CreateInstance(Type type)
            {
                ConstructorInfo[] ctorsPublic = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
                if (ctorsPublic.Length > 0)
                {
                    throw new Exception($"{type.FullName} has one or more public constructors so the property cannot be enforced.");
                }

                ConstructorInfo ctorsNonPublic = type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], new ParameterModifier[0]);
                if (ctorsNonPublic == null)
                {
                    throw new Exception($"{type.FullName} does not have a private/protected constructor so the property cannot be enforced.");
                }

                try
                {
                    return Instance = (T) ctorsNonPublic.Invoke(new object[0]);
                }
                catch (Exception ex)
                {
                    throw new Exception(
                        $"The Singleton could not be constructed. Check if {type.FullName} has a default constructor.",
                        ex);
                }
            }
        }
    }
}
