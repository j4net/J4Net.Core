using System;
using System.Threading;

namespace JNet.Core
{
    public abstract class Ref : IDisposable
    {
        public IntPtr Ptr { get; }
        protected int disposed;

        protected Ref(IntPtr ptr)
        {
            Ptr = ptr;
        }

        public bool IsZero()
        {
            return Ptr == IntPtr.Zero;
        }

        public void Dispose()
        {
            if (Interlocked.CompareExchange(ref disposed, 1, 0) == 0)
            {
                RemovePtr(Ptr);
            }
        }

        protected abstract void RemovePtr(IntPtr ptr);
    }
}