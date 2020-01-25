using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Injection.Core
{
    public static class Injection
    {
        /// <summary>
        /// Method Injection
        /// </summary>
        /// <remarks>
        /// License(ライセンス)
        /// URL: https://stackoverflow.com/questions/7299097/dynamically-replace-the-contents-of-a-c-sharp-method
        /// User: https://stackoverflow.com/users/1938988/johnny-5
        /// User Name: johnny 5
        /// </remarks>
        /// <param name="target">Replacement Function</param>
        /// <param name="injection">Injection Function</param>
        /// <returns>Backup Disposable Instance</returns>
        public static InjectionState Set(MethodInfo target, MethodInfo injection)
        {
            RuntimeHelpers.PrepareMethod(target.MethodHandle);
            RuntimeHelpers.PrepareMethod(injection.MethodHandle);

            InjectionState state;

            unsafe
            {
                IntPtr tar = target.MethodHandle.Value;
                if (!target.IsVirtual)
                    tar += 8;
                else
                {
                    var index = (int)(((*(long*)tar) >> 32) & 0xFF);
                    var classStart = *(IntPtr*)(target.DeclaringType.TypeHandle.Value + (IntPtr.Size == 4 ? 40 : 64));
                    tar = classStart + IntPtr.Size * index;
                }
                var inj = injection.MethodHandle.Value + 8;
                IntPtr value;

                if (Debugger.IsAttached)
                {
                    tar = *(IntPtr*)tar + 1;
                    inj = *(IntPtr*)inj + 1;
                    int pointer = *(int*)inj + (int)(long)inj - (int)(long)tar;
                    value = (IntPtr)pointer;
                }
                else
                {
                    value = *(IntPtr*)inj;
                }

                // Backup
                state.Address = new IntPtr((int)tar);
                state.Value = new IntPtr(*(int*)tar);

                // Injection
                *(IntPtr*)tar = value;
            }

            return state;
        }
    }
}
