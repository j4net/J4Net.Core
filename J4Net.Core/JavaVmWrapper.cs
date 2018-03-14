using System;
using System.Runtime.InteropServices;
using J4Net.Core.JNICore.Interface;

namespace J4Net.Core
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

        public unsafe int GetEnv(IntPtr* env, int version)
        {
            return GetDelegate<GetEnv>(functions.GetEnvVoidMethodPtr).Invoke(javaVmPtr, env, version);
        }

        public unsafe int DetachCurrentThread()
        {
            return GetDelegate<DetachCurrentThread>(functions.DetachCurrentThreadVoidMethodPtr).Invoke(javaVmPtr);
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