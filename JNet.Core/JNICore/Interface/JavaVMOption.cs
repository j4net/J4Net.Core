using System;
using System.Runtime.InteropServices;

namespace JNet.Core.JNICore.Interface
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JavaVmOption
    {
        [MarshalAs(UnmanagedType.LPStr)] private string optionString;
        private IntPtr extraInfo;

        public JavaVmOption(string optionString)
        {
            this.optionString = optionString;
            this.extraInfo = IntPtr.Zero;
        }

        public string OptionString
        {
            get { return optionString; }
        }
    }
}