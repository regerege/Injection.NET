using System;

namespace Injection.Core
{
    public struct InjectionState : IDisposable
    {
        internal IntPtr Address;
        internal IntPtr Value;

        public void Dispose()
        {
            Restore();
        }

        private unsafe void Restore()
        {
            if (IntPtr.Size == 4)
            {
                *(int*)Address = (int)Value;
            }
            else
            {
                *(long*)Address = (long)Value;
            }
        }
    }
}
