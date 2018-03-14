using System;
using System.Threading;

namespace J4Net.Core
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
                RemovePtr();
            }
        }

        protected abstract void RemovePtr();
    }
}