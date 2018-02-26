using System;
using J4Net.Core.JNICore.Interface;

namespace J4Net.Core.JNICore.Library
{
    public class JvmLibrary : Library
    {
        public JvmLibrary(IntPtr dllModule) : base(dllModule)
        {
        }

        public void GetDefaultJavaVmInitArgs(ref JavaVmInitArgs args)
        {
            GetDelegate<GetDefaultJavaVmInitArgs>("JNI_GetDefaultJavaVMInitArgs")(ref args);
        }

        public unsafe void CreateJavaVm(IntPtr* vmP, IntPtr* envP, IntPtr vmArgsP)
        {
            var result = GetDelegate<CreateJavaVm>("JNI_CreateJavaVM")(vmP, envP, vmArgsP);
            if (result != 0)
            {
                throw new InvalidOperationException(string.Format("CreateJavaVM failed - return value obtained: {0}",
                    result));
            }
        }
    }
}