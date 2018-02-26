﻿using System;
using System.Runtime.InteropServices;

namespace JNet.Core.JNICore.Interface
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JniNativeMethod
    {
        [MarshalAs(UnmanagedType.ByValArray)] private readonly byte[] name;
        [MarshalAs(UnmanagedType.ByValArray)] private readonly byte[] signature;
        private readonly IntPtr fnPtr;
    };
}