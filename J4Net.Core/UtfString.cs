using System;
using System.Threading;

namespace J4Net.Core
{
    public class UtfString : IDisposable
    {
        public readonly Ref reference;
        public IntPtr Ptr { get { return reference.Ptr; } }
        protected int disposed;

        public UtfString(Ref reference)
        {
            this.reference = reference;
        } 

        public void Dispose()
        {
            if (Interlocked.CompareExchange(ref disposed, 1, 0) == 0)
            {
                try
                {
                    using (var chars = JvmManager.INSTANCE.GetEnv().GetStringUtfChars(reference.Ptr, false))
                    {
                        JvmManager.INSTANCE.GetEnv().ReleaseStringUtfChars(reference.Ptr, chars.Ptr);
                    }
                }
                finally
                {
                    reference.Dispose();
                }
            }
        }
    }
}
