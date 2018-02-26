using System;
using System.Runtime.InteropServices;

namespace JNet.Core.JNICore.Interface
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JniEnv
    {
        private readonly IntPtr functions;

        public IntPtr Functions
        {
            get { return functions; }
        }
    }
}