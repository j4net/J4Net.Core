using System;

namespace JNet.Core
{
    public class LocalRef : Ref
    {
        public LocalRef(IntPtr ptr) : base(ptr)
        {
        }
        protected override void RemovePtr(IntPtr ptr)
        {
            JvmManager.INSTANCE.GetEnv().DeleteLocalRef(ptr);
        }
    }
}