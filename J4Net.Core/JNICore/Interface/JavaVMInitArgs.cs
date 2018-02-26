using System;
using System.Runtime.InteropServices;

namespace J4Net.Core.JNICore.Interface
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JavaVmInitArgs
    {
        private int version;
        private int nOptions;
        private IntPtr options;
        [MarshalAs(UnmanagedType.U1)] private readonly bool ignoreUnrecognized;

        public IntPtr Options
        {
            get { return options; }
            set { options = value; }
        }

        public int NOptions
        {
            get { return nOptions; }
            set { nOptions = value; }
        }

        public int Version
        {
            get { return version; }
            set { version = value; }
        }
    }
}