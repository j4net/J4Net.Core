using System;
using System.Runtime.InteropServices;

namespace J4Net.Core.JNICore.Interface
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JniInvokeInterface
    {
        private readonly IntPtr reserved0;
        private readonly IntPtr reserved1;
        private readonly IntPtr reserved2;
        private readonly IntPtr DestroyJavaVMVoidMethod;
        private readonly IntPtr AttachCurrentThreadVoidMethod;
        private readonly IntPtr DetachCurrentThreadVoidMethod;
        private readonly IntPtr GetEnvVoidMethod;
        private readonly IntPtr AttachCurrentThreadAsDaemonVoidMethod;

        public IntPtr DestroyJavaVMVoidMethodPtr
        {
            get { return DestroyJavaVMVoidMethod; }
        }

        public IntPtr AttachCurrentThreadVoidMethodPtr
        {
            get { return AttachCurrentThreadVoidMethod; }
        }

        public IntPtr DetachCurrentThreadVoidMethodPtr
        {
            get { return DetachCurrentThreadVoidMethod; }
        }

        public IntPtr GetEnvVoidMethodPtr
        {
            get { return GetEnvVoidMethod; }
        }

        public IntPtr AttachCurrentThreadAsDaemonVoidMethodPtr
        {
            get { return AttachCurrentThreadAsDaemonVoidMethod; }
        }
    }
}