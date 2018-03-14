using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using J4Net.Core.JNICore.Interface;
using J4Net.Core.Util;

namespace J4Net.Core
{
    public class JniEnvWrapper
    {
        private IntPtr envPtr;
        private JniNativeInterface functions;

        private static readonly ConcurrentDictionary<IntPtr, Delegate> DelegatesCache =
            new ConcurrentDictionary<IntPtr, Delegate>();

        public JniEnvWrapper(IntPtr envPtr)
        {
            this.envPtr = envPtr;
            var env = (JniEnv) Marshal.PtrToStructure(envPtr, typeof(JniEnv));
            functions = (JniNativeInterface) Marshal.PtrToStructure(env.Functions, typeof(JniNativeInterface));
        }

        public LocalRef NewByteArray(byte[] elements)
        {
            var ret = SafeJniCall(GetDelegate<NewByteArray>(functions.NewByteArrayPtr).Invoke, elements.Length);
            SafeJniCallA(GetDelegate<SetByteArrayRegion>(functions.SetByteArrayRegionPtr).Invoke, ret, 0,
                elements.Length, elements);
            return new LocalRef(ret);
        }

        public byte[] GetByteArray(IntPtr array)
        {
            var length = SafeJniCall(GetDelegate<GetArrayLength>(functions.GetArrayLengthPtr).Invoke, array);

            var buffer = new byte[length];
            SafeJniCallA(GetDelegate<GetByteArrayRegion>(functions.GetByteArrayRegionPtr).Invoke, array, 0, length,
                buffer);
            return buffer;
        }

        private void SafeJniCallA<A, B, C, D>(Action<IntPtr, A, B, C, D> func, A arg1, B arg2, C arg3, D arg4)
        {
            SafeJniCall<object>(() =>
            {
                func(this.envPtr, arg1, arg2, arg3, arg4);
                return null;
            });
        }

        public GlobalRef FindClass(string className)
        {
            var localRef = SafeJniCall(GetDelegate<FindClass>(functions.FindClassPtr).Invoke, className.ToUtfBytes());
            try
            {
                return GetGlobalRef(localRef);
            }
            finally
            {
                DeleteLocalRef(localRef);
            }
        }

        public GlobalRef DefineClass(string name, IntPtr loader, byte[] buf, int len)
        {
            var localRef = SafeJniCall(GetDelegate<DefineClass>(functions.DefineClassPtr).Invoke, name.ToUtfBytes(),
                loader, buf, len);
            try
            {
                return GetGlobalRef(localRef);
            }
            finally
            {
                DeleteLocalRef(localRef);
            }
        }

        public GlobalRef NewObject(IntPtr clazz, IntPtr methodId, params JValue[] args)
        {
            var localRef = SafeJniCall(GetDelegate<NewObject>(functions.NewObjectAPtr).Invoke, clazz, methodId,
                args);
            try
            {
                return GetGlobalRef(localRef);
            }
            finally
            {
                DeleteLocalRef(localRef);
            }
        }

        public GlobalRef GetMethodId(IntPtr classP, string name, string sig)
        {
            var localRef = SafeJniCall(GetDelegate<GetMethodId>(functions.GetMethodIDPtr).Invoke, classP,
                name.ToUtfBytes(), sig.ToUtfBytes());

            try
            {
                return GetGlobalRef(localRef);
            }
            finally
            {
                DeleteLocalRef(localRef);
            }
        }

        private GlobalRef GetGlobalRef(IntPtr localRef)
        {
            return new GlobalRef(SafeJniCall(GetDelegate<NewGlobalRef>(functions.NewGlobalRefPtr).Invoke, localRef));
        }

        public LocalRef NewDirectByteBuffer(IntPtr data, long length)
        {
            return new LocalRef(
                SafeJniCall(GetDelegate<NewDirectByteBuffer>(functions.NewDirectByteBufferPtr).Invoke, data,
                    length)
            );
        }

        public IntPtr GetDBBAddress(IntPtr buffer)
        {
            return SafeJniCall(GetDelegate<GetDirectBufferAddress>(functions.GetDirectBufferAddressPtr).Invoke, buffer);
        }

        public long GetDBBCapacity(IntPtr buffer)
        {
            return SafeJniCall(GetDelegate<GetDirectBufferCapacity>(functions.GetDirectBufferCapacityPtr).Invoke,
                buffer);
        }

        public void SetArrayElement(IntPtr buffer, int index, byte element)
        {
            SafeJniCallA(GetDelegate<SetObjectArrayElement>(functions.SetObjectArrayElementPtr).Invoke, buffer,
                index,
                (IntPtr) element);
        }

        private void SafeJniCallA(Action<IntPtr, IntPtr, int, IntPtr> func, IntPtr buffer, int index, IntPtr element)
        {
            SafeJniCall<object>(() =>
            {
                func(envPtr, buffer, index, element);
                return null;
            });
        }

        public GlobalRef GetStaticMethodId(IntPtr classP, string name, string sig)
        {
            var localRef = SafeJniCall(GetDelegate<GetStaticMethodId>(functions.GetStaticMethodIDPtr).Invoke, classP,
                name.ToUtfBytes(), sig.ToUtfBytes());
            try
            {
                return GetGlobalRef(localRef);
            }
            finally
            {
                DeleteLocalRef(localRef);
            }
        }

        public LocalRef CallObjectMethod(IntPtr obj, IntPtr methodId, params JValue[] args)
        {
            return new LocalRef(
                SafeJniCall(GetDelegate<CallObjectMethodA>(functions.CallObjectMethodAPtr).Invoke, obj,
                    methodId, args));
        }

        public void CallVoidMethod(IntPtr obj, IntPtr methodId, params JValue[] args)
        {
            SafeJniCallVoid(GetDelegate<CallVoidMethodA>(functions.CallVoidMethodAPtr).Invoke, obj,
                methodId, args);
        }

        public int CallIntMethod(IntPtr obj, IntPtr methodId, params JValue[] args)
        {
            return
                SafeJniCall(GetDelegate<CallIntMethodA>(functions.CallIntMethodAPtr).Invoke, obj,
                    methodId, args);
        }

        public int CallStaticIntMethod(IntPtr classP, IntPtr methodId, params JValue[] args)
        {
            return SafeJniCall(GetDelegate<CallStaticIntMethodA>(functions.CallStaticIntMethodAPtr).Invoke,
                classP, methodId, args);
        }

        public void CallStaticVoidMethod(IntPtr classP, IntPtr methodId, params JValue[] args)
        {
            SafeJniCallA(GetDelegate<CallStaticVoidMethodA>(functions.CallStaticVoidMethodAPtr).Invoke, classP,
                methodId, args);
        }


        public UtfString NewStringUtf(string utf)
        {
            return new UtfString(
                new LocalRef(
                    SafeJniCall(GetDelegate<NewStringUtf>(functions.NewStringUTFPtr).Invoke,
                        utf.ToUtfBytes())
                ));
        }

        public LocalRef GetStringUtfChars(IntPtr str, bool isCopy)
        {
            return new LocalRef(
                SafeJniCall(GetDelegate<GetStringUtfChars>(functions.GetStringUTFCharsPtr).Invoke, str, isCopy)
            );
        }

        public void ReleaseStringUtfChars(IntPtr str, IntPtr chars)
        {
            SafeJniCallA(GetDelegate<ReleaseStringUtfChars>(functions.ReleaseStringUTFCharsPtr).Invoke, str, chars);
        }

        public string GetString(IntPtr stringPointer)
        {
            var stringChars = SafeJniCall(GetDelegate<GetStringChars>(functions.GetStringCharsPtr).Invoke,
                stringPointer, IntPtr.Zero);
            try
            {
                return Marshal.PtrToStringUni(stringChars);
            }
            finally
            {
                SafeJniCallA(GetDelegate<ReleaseStringChars>(functions.ReleaseStringCharsPtr).Invoke,
                    stringPointer, stringChars);
            }
        }

        public LocalRef[] GetArray(IntPtr arrayPtr)
        {
            var length = SafeJniCall(GetDelegate<GetArrayLength>(functions.GetArrayLengthPtr).Invoke,
                arrayPtr);
            var ret = new LocalRef[length];
            for (var i = 0; i < length; i++)
            {
                ret[i] =
                    new LocalRef(
                        SafeJniCall(GetDelegate<GetObjectArrayElement>(functions.GetObjectArrayElementPtr).Invoke,
                            arrayPtr, i));
            }
            return ret;
        }

        public LocalRef CallStaticObjectMethod(IntPtr classP, IntPtr methodId, params JValue[] args)
        {
            return new LocalRef(
                SafeJniCall(GetDelegate<CallStaticObjectMethodA>(functions.CallStaticObjectMethodAPtr).Invoke,
                    classP,
                    methodId, args));
        }

        public void DeleteLocalRef(IntPtr localRef)
        {
            SafeJniCallA(GetDelegate<DeleteLocalRef>(functions.DeleteLocalRefPtr).Invoke, localRef);
        }

        public void DeleteGlobalRef(IntPtr globalRef)
        {
            SafeJniCallA(GetDelegate<DeleteGlobalRef>(functions.DeleteGlobalRefPtr).Invoke, globalRef);
        }

        private void SafeJniCallA<TA, TB>(Action<IntPtr, TA, TB> func, TA arg1, TB arg2)
        {
            SafeJniCall<object>(() =>
            {
                func(envPtr, arg1, arg2);
                return null;
            });
        }

        private TC SafeJniCall<TA, TB, TC>(Func<IntPtr, TA, TB, TC> func, TA arg1, TB arg2)
        {
            return SafeJniCall(() => func(envPtr, arg1, arg2));
        }

        private TB SafeJniCall<TA, TB>(Func<IntPtr, TA, TB> func, TA arg1)
        {
            return SafeJniCall(() => func(envPtr, arg1));
        }

        private TD SafeJniCall<TA, TB, TC, TD>(Func<IntPtr, TA, TB, TC, TD> func, TA arg1, TB arg2, TC arg3)
        {
            return SafeJniCall(() => func(envPtr, arg1, arg2, arg3));
        }

        private void SafeJniCallVoid<TA, TB, TC>(Action<IntPtr, TA, TB, TC> func, TA arg1, TB arg2, TC arg3)
        {
            SafeJniCallVoid(() => func(envPtr, arg1, arg2, arg3));
        }

        private TE SafeJniCall<TA, TB, TC, TD, TE>(Func<IntPtr, TA, TB, TC, TD, TE> func, TA arg1, TB arg2, TC arg3,
            TD arg4)
        {
            return SafeJniCall(() => func(envPtr, arg1, arg2, arg3, arg4));
        }

        private void SafeJniCallA<TA, TB, TC>(Action<IntPtr, TA, TB, TC> func, TA arg1, TB arg2, TC arg3)
        {
            SafeJniCall<object>(() =>
            {
                func(envPtr, arg1, arg2, arg3);
                return null;
            });
        }

        private void SafeJniCallA<TA>(Action<IntPtr, TA> func, TA arg1)
        {
            SafeJniCall<object>(() =>
            {
                func(envPtr, arg1);
                return null;
            });
        }

        private T SafeJniCall<T>(Func<T> func)
        {
            GetDelegate<ExceptionClear>(functions.ExceptionClearPtr)(envPtr);
            var result = func();

            return result;
        }

        private void SafeJniCallVoid(Action func)
        {
            ClearContext();
            func();
        }

        public bool TryCatchEcxeption(out LocalRef ex)
        {
            if (GetDelegate<ExceptionCheck>(functions.ExceptionCheckPtr)(envPtr))
            {
                ex = new LocalRef(GetDelegate<ExceptionOccurred>(functions.ExceptionOccurredPtr)(envPtr));
                return true;
            }

            ex = null;
            return false;
        }

        public void ClearContext()
        {
            GetDelegate<ExceptionClear>(functions.ExceptionClearPtr)(envPtr);
        }

        private static T GetDelegate<T>(IntPtr ptr) where T : class
        {
            return DelegatesCache.GetOrAdd(ptr, key => Marshal.GetDelegateForFunctionPointer(key, typeof(T))) as T;
        }
    }
}