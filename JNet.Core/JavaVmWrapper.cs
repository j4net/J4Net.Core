using System;
using System.Runtime.InteropServices;
using JNet.Core.JNICore.Interface;

namespace JNet.Core
{
    public class JavaVmWrapper
    {
        private JniInvokeInterface functions;
        private readonly IntPtr javaVmPtr;

        public JavaVmWrapper(IntPtr javaVmPtr)
        {
            this.javaVmPtr = javaVmPtr;
            var vm = (JavaVm) Marshal.PtrToStructure(javaVmPtr, typeof(JavaVm));
            functions = (JniInvokeInterface) Marshal.PtrToStructure(vm.Functions, typeof(JniInvokeInterface));
        }

        public unsafe int AttachCurrentThread(IntPtr* env, IntPtr arg)
        {
            return GetDelegate<AttachCurrentThread>(functions.AttachCurrentThreadVoidMethodPtr)
                .Invoke(javaVmPtr, env, arg);
        }
        public int DestroyJavaVm()
        {
            return GetDelegate<DestroyJavaVm>(functions.DestroyJavaVMVoidMethodPtr).Invoke(javaVmPtr);
        }

        private T GetDelegate<T>(IntPtr ptr) where T : class
        {
            return Marshal.GetDelegateForFunctionPointer(ptr, typeof(T)) as T;
        }
    }
}