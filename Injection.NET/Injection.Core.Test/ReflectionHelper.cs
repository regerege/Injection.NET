using System;
using System.Reflection;

namespace Injection.Core.Test
{
    public static class ReflectionHelper
    {
        private const BindingFlags Flag =
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Static |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly |
            BindingFlags.CreateInstance;

        public static Type GetType(string name)
        {
            return Assembly.GetExecutingAssembly().GetType(name);
        }

        public static MethodInfo GetMethod(this Type t, string name, Type[] args = null)
        {
            args = new Type[0];
            return t.GetMethod(name, args)
                ?? t.GetMethod(name, Flag);
        }

        public static PropertyInfo GetProperty(this Type t, string name)
        {
            return t.GetProperty(name)
                ?? t.GetProperty(name, Flag);
        }

        public static MethodInfo GetMethod<T>(string name, Type[] args = null)
        {
            return GetMethod(typeof(T), name, args);
        }

        public static PropertyInfo GetProperty<T>(string name)
        {
            return GetProperty(typeof(T), name);
        }
    }
}
