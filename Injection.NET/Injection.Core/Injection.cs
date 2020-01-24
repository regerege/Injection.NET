using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Injection.Core
{
    public static class Injection
    {
        public static InjectionState Set(MethodInfo target, MethodInfo injection)
        {
            RuntimeHelpers.PrepareMethod(target.MethodHandle);
            RuntimeHelpers.PrepareMethod(injection.MethodHandle);

            if (Debugger.IsAttached)
            {
                return Set32bitAttached(target, injection);
            }
            else
            {
                // TODO: I will investigate later that the restoration cannot be performed.
                return Set32bit(target, injection);
            }
        }

        private static unsafe InjectionState Set32bit(MethodInfo target, MethodInfo injection)
        {
            var targetPointer = (int*)target.MethodHandle.Value.ToPointer() + 2;
            var injectionPointer = (int*)injection.MethodHandle.Value.ToPointer() + 2;

            // Backup Pointer Original Value
            var state = new InjectionState()
            {
                Address = new IntPtr((int)targetPointer),
                Value = new IntPtr((int)*targetPointer),
            };

            // Injection
            *targetPointer = *injectionPointer;

            return state;
        }

        private static unsafe InjectionState Set32bitAttached(MethodInfo target, MethodInfo injection)
        {
            var aa = target.MethodHandle.GetFunctionPointer();
            var bb = injection.MethodHandle.GetFunctionPointer();

            var targetPointer = (int*)target.MethodHandle.Value.ToPointer() + 2;
            var injectionPointer = (int*)injection.MethodHandle.Value.ToPointer() + 2;

            var targetInstance = (byte*)targetPointer;
            var injectionInstance = (byte*)injectionPointer;

            var targetSource = (int*)(targetInstance + 1);
            var injectionSource = (int*)(injectionInstance + 1);

            // Backup Pointer Original Value
            var state = new InjectionState()
            {
                Address = new IntPtr((int)targetSource),
                Value = new IntPtr((int)*targetSource),
            };

            // Injection
            var a = (((int)injectionInstance + 5) + *injectionSource);
            var b = ((int)targetInstance + 5);
            *targetSource = a - b;

            return state;
        }
    }
}
