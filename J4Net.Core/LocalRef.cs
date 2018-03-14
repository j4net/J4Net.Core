using System;

namespace J4Net.Core
{
    public class LocalRef : Ref
    {
        public LocalRef(IntPtr ptr) : base(ptr)
        {
        }
        protected override void RemovePtr()
        {
            JvmManager.INSTANCE.GetEnv().DeleteLocalRef(Ptr);
        }
    }
}