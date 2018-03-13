﻿using System;

namespace J4Net.Core
{
    public class GlobalRef : Ref
    {
        public GlobalRef(IntPtr ptr) : base(ptr)
        {
        }

        ~GlobalRef()
        {
            Dispose();
        }

        protected override void RemovePtr(IntPtr ptr)
        {
            JvmManager.INSTANCE.GetEnv().DeleteGlobalRef(ptr);
        }
    }
}