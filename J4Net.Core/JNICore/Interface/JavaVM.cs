using System;
using System.Runtime.InteropServices;

namespace J4Net.Core.JNICore.Interface
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JavaVm
    {
        private readonly IntPtr functions;

        public IntPtr Functions
        {
            get { return functions; }
        }
    }
}