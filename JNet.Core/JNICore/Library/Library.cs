using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace JNet.Core.JNICore.Library
{
    public class Library : IDisposable
    {
        [DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
        private static extern bool FreeLibrary(IntPtr hModule);

        [DllImport("kernel32.dll", EntryPoint = "GetProcAddress")]
        private static extern IntPtr GetProcAddress(IntPtr hModule, [MarshalAs(UnmanagedType.LPStr)] string name);

        protected IntPtr DllModule;

        public Library(IntPtr dllModule)
        {
            DllModule = dllModule;
        }

        protected T GetDelegate<T>(string procName) where T : class
        {
            return Marshal.GetDelegateForFunctionPointer(GetProcAddress(DllModule, procName), typeof(T)) as T;
        }

        public void Dispose()
        {
            if (DllModule == IntPtr.Zero)
            {
                return;
            }

            if (!FreeLibrary(DllModule))
            {
                throw new Win32Exception();
            }

            DllModule = IntPtr.Zero;
        }
    }
}