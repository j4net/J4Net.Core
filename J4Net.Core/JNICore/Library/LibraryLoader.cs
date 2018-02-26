using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace J4Net.Core.JNICore.Library
{
    public static class LibraryLoader
    {
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryW")]
        private static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPWStr)] string name);

        public static IntPtr LoadUnmanagedLibrary(string libraryPath)
        {
            var dllModule = LoadLibrary(libraryPath);
            if (dllModule == IntPtr.Zero)
            {
                throw new Win32Exception();
            }

            return dllModule;
        }
    }
}