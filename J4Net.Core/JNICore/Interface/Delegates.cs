using System;
using System.Runtime.InteropServices;

namespace J4Net.Core.JNICore.Interface
{
    unsafe delegate int CreateJavaVm(IntPtr* pvm, IntPtr* penv, IntPtr args);

    delegate int GetDefaultJavaVmInitArgs(ref JavaVmInitArgs args);

    delegate int DestroyJavaVm(IntPtr vm);

    unsafe delegate int AttachCurrentThread(IntPtr pvm, IntPtr* penv, IntPtr args);

    delegate int DetachCurrentThread(IntPtr vm);

    unsafe delegate int GetEnv(IntPtr vm, IntPtr* penv, int version);

    unsafe delegate int AttachCurrentThreadAsDaemon(IntPtr vm, IntPtr* penv, IntPtr args);


    delegate int GetVersion(IntPtr env);

    delegate IntPtr DefineClass
    (IntPtr env, [MarshalAs(UnmanagedType.LPArray)] byte[] utf, IntPtr loader,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] byte[] buf, int len);

    delegate IntPtr FindClass
        (IntPtr env, [MarshalAs(UnmanagedType.LPArray)] byte[] utf);

    delegate IntPtr FromReflectedMethod
        (IntPtr env, IntPtr method);

    delegate IntPtr FromReflectedField
        (IntPtr env, IntPtr field);

    delegate IntPtr ToReflectedMethod
        (IntPtr env, IntPtr cls, IntPtr methodId, [MarshalAs(UnmanagedType.U1)] bool isStatic);

    delegate IntPtr GetSuperclass
        (IntPtr env, IntPtr sub);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool IsAssignableFrom
        (IntPtr env, IntPtr sub, IntPtr sup);

    delegate IntPtr ToReflectedField
        (IntPtr env, IntPtr cls, IntPtr fieldId, [MarshalAs(UnmanagedType.U1)] bool isStatic);

    delegate int Throw
        (IntPtr env, IntPtr obj);

    delegate int ThrowNew
        (IntPtr env, IntPtr clazz, [MarshalAs(UnmanagedType.LPArray)] byte[] utf);

    delegate IntPtr ExceptionOccurred
        (IntPtr env);

    delegate void ExceptionDescribe
        (IntPtr env);

    public delegate void ExceptionClear
        (IntPtr env);

    delegate void FatalError
        (IntPtr env, [MarshalAs(UnmanagedType.LPArray)] byte[] utf);

    delegate int PushLocalFrame
        (IntPtr env, int capacity);

    delegate IntPtr PopLocalFrame
        (IntPtr env, IntPtr result);

    delegate IntPtr NewGlobalRef
        (IntPtr env, IntPtr lobj);

    delegate void DeleteGlobalRef
        (IntPtr env, IntPtr gref);

    delegate void DeleteLocalRef
        (IntPtr env, IntPtr obj);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool IsSameObject
        (IntPtr env, IntPtr obj1, IntPtr obj2);

    delegate IntPtr NewLocalRef
        (IntPtr env, IntPtr reference);

    delegate int EnsureLocalCapacity
        (IntPtr env, int capacity);

    delegate IntPtr AllocObject
        (IntPtr env, IntPtr clazz);

    delegate IntPtr NewObject
        (IntPtr env, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate IntPtr NewObjectV
        (IntPtr env, IntPtr clazz, IntPtr methodId, IntPtr args);

    delegate IntPtr NewObjectA
        (IntPtr env, IntPtr clazz, IntPtr methodId, JValue[] args);

    delegate IntPtr GetObjectClass
        (IntPtr env, IntPtr obj);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool IsInstanceOf
        (IntPtr env, IntPtr obj, IntPtr clazz);

    delegate IntPtr GetMethodId
    (IntPtr env, IntPtr clazz, [MarshalAs(UnmanagedType.LPArray)] byte[] utf,
        [MarshalAs(UnmanagedType.LPArray)] byte[] sig);

    delegate IntPtr CallObjectMethod
        (IntPtr env, IntPtr obj, IntPtr methodId, params JValue[] args);

    delegate IntPtr CallObjectMethodV
        (IntPtr env, IntPtr obj, IntPtr methodId, IntPtr args);

    delegate IntPtr CallObjectMethodA
        (IntPtr env, IntPtr obj, IntPtr methodId, JValue[] args);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool CallBooleanMethod
        (IntPtr env, IntPtr obj, IntPtr methodId, params JValue[] args);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool CallBooleanMethodV
        (IntPtr env, IntPtr obj, IntPtr methodId, IntPtr args);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool CallBooleanMethodA
        (IntPtr env, IntPtr obj, IntPtr methodId, JValue[] args);

    delegate byte CallByteMethod
        (IntPtr env, IntPtr obj, IntPtr methodId, params JValue[] args);

    delegate byte CallByteMethodV
        (IntPtr env, IntPtr obj, IntPtr methodId, IntPtr args);

    delegate byte CallByteMethodA
        (IntPtr env, IntPtr obj, IntPtr methodId, JValue[] args);

    delegate char CallCharMethod
        (IntPtr env, IntPtr obj, IntPtr methodId, params JValue[] args);

    delegate char CallCharMethodV
        (IntPtr env, IntPtr obj, IntPtr methodId, IntPtr args);

    delegate char CallCharMethodA
        (IntPtr env, IntPtr obj, IntPtr methodId, JValue[] args);

    delegate short CallShortMethod
        (IntPtr env, IntPtr obj, IntPtr methodId, params JValue[] args);

    delegate short CallShortMethodV
        (IntPtr env, IntPtr obj, IntPtr methodId, IntPtr args);

    delegate short CallShortMethodA
        (IntPtr env, IntPtr obj, IntPtr methodId, JValue[] args);

    delegate int CallIntMethod
        (IntPtr env, IntPtr obj, IntPtr methodId, params JValue[] args);

    delegate int CallIntMethodV
        (IntPtr env, IntPtr obj, IntPtr methodId, IntPtr args);

    delegate int CallIntMethodA
        (IntPtr env, IntPtr obj, IntPtr methodId, JValue[] args);

    delegate long CallLongMethod
        (IntPtr env, IntPtr obj, IntPtr methodId, params JValue[] args);

    delegate long CallLongMethodV
        (IntPtr env, IntPtr obj, IntPtr methodId, IntPtr args);

    delegate long CallLongMethodA
        (IntPtr env, IntPtr obj, IntPtr methodId, JValue[] args);

    delegate float CallFloatMethod
        (IntPtr env, IntPtr obj, IntPtr methodId, params JValue[] args);

    delegate float CallFloatMethodV
        (IntPtr env, IntPtr obj, IntPtr methodId, IntPtr args);

    delegate float CallFloatMethodA
        (IntPtr env, IntPtr obj, IntPtr methodId, JValue[] args);

    delegate double CallDoubleMethod
        (IntPtr env, IntPtr obj, IntPtr methodId, params JValue[] args);

    delegate double CallDoubleMethodV
        (IntPtr env, IntPtr obj, IntPtr methodId, IntPtr args);

    delegate double CallDoubleMethodA
        (IntPtr env, IntPtr obj, IntPtr methodId, JValue[] args);

    delegate void CallVoidMethod
        (IntPtr env, IntPtr obj, IntPtr methodId, params JValue[] args);

    delegate void CallVoidMethodV
        (IntPtr env, IntPtr obj, IntPtr methodId, IntPtr args);

    delegate void CallVoidMethodA
        (IntPtr env, IntPtr obj, IntPtr methodId, JValue[] args);

    delegate IntPtr CallNonvirtualObjectMethod
        (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate IntPtr CallNonvirtualObjectMethodV
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        IntPtr args);

    delegate IntPtr CallNonvirtualObjectMethodA
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        JValue[] args);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool CallNonvirtualBooleanMethod
        (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId, params JValue[] args);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool CallNonvirtualBooleanMethodV
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        IntPtr args);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool CallNonvirtualBooleanMethodA
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        JValue[] args);

    delegate byte CallNonvirtualByteMethod
        (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate byte CallNonvirtualByteMethodV
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        IntPtr args);

    delegate byte CallNonvirtualByteMethodA
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        JValue[] args);

    delegate ushort CallNonvirtualCharMethod
        (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate ushort CallNonvirtualCharMethodV
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        IntPtr args);

    delegate ushort CallNonvirtualCharMethodA
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        JValue[] args);

    delegate short CallNonvirtualShortMethod
        (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate short CallNonvirtualShortMethodV
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        IntPtr args);

    delegate short CallNonvirtualShortMethodA
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        JValue[] args);

    delegate int CallNonvirtualIntMethod
        (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate int CallNonvirtualIntMethodV
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        IntPtr args);

    delegate int CallNonvirtualIntMethodA
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        JValue[] args);

    delegate long CallNonvirtualLongMethod
        (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate long CallNonvirtualLongMethodV
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        IntPtr args);

    delegate long CallNonvirtualLongMethodA
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        JValue[] args);

    delegate float CallNonvirtualFloatMethod
        (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate float CallNonvirtualFloatMethodV
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        IntPtr args);

    delegate float CallNonvirtualFloatMethodA
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        JValue[] args);

    delegate double CallNonvirtualDoubleMethod
        (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate double CallNonvirtualDoubleMethodV
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        IntPtr args);

    delegate double CallNonvirtualDoubleMethodA
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        JValue[] args);

    delegate void CallNonvirtualVoidMethod
        (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate void CallNonvirtualVoidMethodV
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        IntPtr args);

    delegate void CallNonvirtualVoidMethodA
    (IntPtr env, IntPtr obj, IntPtr clazz, IntPtr methodId,
        JValue[] args);

    delegate IntPtr GetFieldId
    (IntPtr env, IntPtr clazz, [MarshalAs(UnmanagedType.LPArray)] byte[] name,
        [MarshalAs(UnmanagedType.LPArray)] byte[] sig);

    delegate IntPtr GetObjectField
        (IntPtr env, IntPtr obj, IntPtr fieldId);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool GetBooleanField
        (IntPtr env, IntPtr obj, IntPtr fieldId);

    delegate byte GetByteField
        (IntPtr env, IntPtr obj, IntPtr fieldId);

    delegate char GetCharField
        (IntPtr env, IntPtr obj, IntPtr fieldId);

    delegate short GetShortField
        (IntPtr env, IntPtr obj, IntPtr fieldId);

    delegate int GetIntField
        (IntPtr env, IntPtr obj, IntPtr fieldId);

    delegate long GetLongField
        (IntPtr env, IntPtr obj, IntPtr fieldId);

    delegate float GetFloatField
        (IntPtr env, IntPtr obj, IntPtr fieldId);

    delegate double GetDoubleField
        (IntPtr env, IntPtr obj, IntPtr fieldId);

    delegate void SetObjectField
        (IntPtr env, IntPtr obj, IntPtr fieldId, IntPtr val);

    delegate void SetBooleanField
        (IntPtr env, IntPtr obj, IntPtr fieldId, [MarshalAs(UnmanagedType.U1)] bool val);

    delegate void SetByteField
        (IntPtr env, IntPtr obj, IntPtr fieldId, byte val);

    delegate void SetCharField
        (IntPtr env, IntPtr obj, IntPtr fieldId, char val);

    delegate void SetShortField
        (IntPtr env, IntPtr obj, IntPtr fieldId, short val);

    delegate void SetIntField
        (IntPtr env, IntPtr obj, IntPtr fieldId, int val);

    delegate void SetLongField
        (IntPtr env, IntPtr obj, IntPtr fieldId, long val);

    delegate void SetFloatField
        (IntPtr env, IntPtr obj, IntPtr fieldId, float val);

    delegate void SetDoubleField
        (IntPtr env, IntPtr obj, IntPtr fieldId, double val);

    delegate IntPtr GetStaticMethodId
    (IntPtr env, IntPtr clazz, [MarshalAs(UnmanagedType.LPArray)] byte[] name,
        [MarshalAs(UnmanagedType.LPArray)] byte[] sig);

    delegate IntPtr CallStaticObjectMethod
        (IntPtr env, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate IntPtr CallStaticObjectMethodV
        (IntPtr env, IntPtr clazz, IntPtr methodId, IntPtr args);

    delegate IntPtr CallStaticObjectMethodA
        (IntPtr env, IntPtr clazz, IntPtr methodId, JValue[] args);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool CallStaticBooleanMethod
        (IntPtr env, IntPtr clazz, IntPtr methodId, params JValue[] args);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool CallStaticBooleanMethodV
        (IntPtr env, IntPtr clazz, IntPtr methodId, IntPtr args);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool CallStaticBooleanMethodA
        (IntPtr env, IntPtr clazz, IntPtr methodId, JValue[] args);

    delegate byte CallStaticByteMethod
        (IntPtr env, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate byte CallStaticByteMethodV
        (IntPtr env, IntPtr clazz, IntPtr methodId, IntPtr args);

    delegate byte CallStaticByteMethodA
        (IntPtr env, IntPtr clazz, IntPtr methodId, JValue[] args);

    delegate char CallStaticCharMethod
        (IntPtr env, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate char CallStaticCharMethodV
        (IntPtr env, IntPtr clazz, IntPtr methodId, IntPtr args);

    delegate char CallStaticCharMethodA
        (IntPtr env, IntPtr clazz, IntPtr methodId, JValue[] args);

    delegate short CallStaticShortMethod
        (IntPtr env, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate short CallStaticShortMethodV
        (IntPtr env, IntPtr clazz, IntPtr methodId, IntPtr args);

    delegate short CallStaticShortMethodA
        (IntPtr env, IntPtr clazz, IntPtr methodId, JValue[] args);

    delegate int CallStaticIntMethod
        (IntPtr env, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate int CallStaticIntMethodV
        (IntPtr env, IntPtr clazz, IntPtr methodId, IntPtr args);

    delegate int CallStaticIntMethodA
        (IntPtr env, IntPtr clazz, IntPtr methodId, JValue[] args);

    delegate long CallStaticLongMethod
        (IntPtr env, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate long CallStaticLongMethodV
        (IntPtr env, IntPtr clazz, IntPtr methodId, IntPtr args);

    delegate long CallStaticLongMethodA
        (IntPtr env, IntPtr clazz, IntPtr methodId, JValue[] args);

    delegate float CallStaticFloatMethod
        (IntPtr env, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate float CallStaticFloatMethodV
        (IntPtr env, IntPtr clazz, IntPtr methodId, IntPtr args);

    delegate float CallStaticFloatMethodA
        (IntPtr env, IntPtr clazz, IntPtr methodId, JValue[] args);

    delegate double CallStaticDoubleMethod
        (IntPtr env, IntPtr clazz, IntPtr methodId, params JValue[] args);

    delegate double CallStaticDoubleMethodV
        (IntPtr env, IntPtr clazz, IntPtr methodId, IntPtr args);

    delegate double CallStaticDoubleMethodA
        (IntPtr env, IntPtr clazz, IntPtr methodId, JValue[] args);

    delegate void CallStaticVoidMethod
        (IntPtr env, IntPtr cls, IntPtr methodId, params JValue[] args);

    delegate void CallStaticVoidMethodV
        (IntPtr env, IntPtr cls, IntPtr methodId, IntPtr args);

    delegate void CallStaticVoidMethodA
        (IntPtr env, IntPtr cls, IntPtr methodId, JValue[] args);

    delegate IntPtr GetStaticFieldId
    (IntPtr env, IntPtr clazz, [MarshalAs(UnmanagedType.LPArray)] byte[] name,
        [MarshalAs(UnmanagedType.LPArray)] byte[] sig);

    delegate IntPtr GetStaticObjectField
        (IntPtr env, IntPtr clazz, IntPtr fieldId);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool GetStaticBooleanField
        (IntPtr env, IntPtr clazz, IntPtr fieldId);

    delegate byte GetStaticByteField
        (IntPtr env, IntPtr clazz, IntPtr fieldId);

    delegate char GetStaticCharField
        (IntPtr env, IntPtr clazz, IntPtr fieldId);

    delegate short GetStaticShortField
        (IntPtr env, IntPtr clazz, IntPtr fieldId);

    delegate int GetStaticIntField
        (IntPtr env, IntPtr clazz, IntPtr fieldId);

    delegate long GetStaticLongField
        (IntPtr env, IntPtr clazz, IntPtr fieldId);

    delegate float GetStaticFloatField
        (IntPtr env, IntPtr clazz, IntPtr fieldId);

    delegate double GetStaticDoubleField
        (IntPtr env, IntPtr clazz, IntPtr fieldId);

    delegate void SetStaticObjectField
        (IntPtr env, IntPtr clazz, IntPtr fieldId, IntPtr value);

    delegate void SetStaticBooleanField
        (IntPtr env, IntPtr clazz, IntPtr fieldId, [MarshalAs(UnmanagedType.U1)] bool value);

    delegate void SetStaticByteField
        (IntPtr env, IntPtr clazz, IntPtr fieldId, byte value);

    delegate void SetStaticCharField
        (IntPtr env, IntPtr clazz, IntPtr fieldId, char value);

    delegate void SetStaticShortField
        (IntPtr env, IntPtr clazz, IntPtr fieldId, short value);

    delegate void SetStaticIntField
        (IntPtr env, IntPtr clazz, IntPtr fieldId, int value);

    delegate void SetStaticLongField
        (IntPtr env, IntPtr clazz, IntPtr fieldId, long value);

    delegate void SetStaticFloatField
        (IntPtr env, IntPtr clazz, IntPtr fieldId, float value);

    delegate void SetStaticDoubleField
        (IntPtr env, IntPtr clazz, IntPtr fieldId, double value);

    delegate IntPtr NewString
        (IntPtr env, IntPtr unicode, int len);

    delegate int GetStringLength
        (IntPtr env, IntPtr str);

    delegate IntPtr GetStringChars
        (IntPtr env, IntPtr str, IntPtr isCopy);

    delegate void ReleaseStringChars
        (IntPtr env, IntPtr str, IntPtr chars);

    delegate IntPtr NewStringUtf
        (IntPtr env, [MarshalAs(UnmanagedType.LPArray)] byte[] utf);

    delegate int GetStringUtfLength
        (IntPtr env, IntPtr str);

    delegate IntPtr GetStringUtfChars
        (IntPtr env, IntPtr str, [MarshalAs(UnmanagedType.U1)] bool isCopy);

    delegate void ReleaseStringUtfChars
        (IntPtr env, IntPtr str, IntPtr chars);


    delegate int GetArrayLength
        (IntPtr env, IntPtr array);

    delegate IntPtr NewObjectArray
        (IntPtr env, int len, IntPtr clazz, IntPtr init);

    delegate IntPtr GetObjectArrayElement
        (IntPtr env, IntPtr array, int index);

    delegate void SetObjectArrayElement
        (IntPtr env, IntPtr array, int index, IntPtr val);

    delegate IntPtr NewBooleanArray
        (IntPtr env, int len);

    delegate IntPtr NewByteArray
        (IntPtr env, int len);

    delegate IntPtr NewCharArray
        (IntPtr env, int len);

    delegate IntPtr NewShortArray
        (IntPtr env, int len);

    delegate IntPtr NewIntArray
        (IntPtr env, int len);

    delegate IntPtr NewLongArray
        (IntPtr env, int len);

    delegate IntPtr NewFloatArray
        (IntPtr env, int len);

    delegate IntPtr NewDoubleArray
        (IntPtr env, int len);

    delegate IntPtr GetBooleanArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.U1)] ref bool isCopy);

    delegate IntPtr GetByteArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.U1)] ref bool isCopy);

    delegate IntPtr GetCharArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.U1)] ref bool isCopy);

    delegate IntPtr GetShortArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.U1)] ref bool isCopy);

    delegate IntPtr GetIntArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.U1)] ref bool isCopy);

    delegate IntPtr GetLongArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.U1)] ref bool isCopy);

    delegate IntPtr GetFloatArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.U1)] ref bool isCopy);

    delegate IntPtr GetDoubleArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.U1)] ref bool isCopy);

    delegate void ReleaseBooleanArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.U1)] ref bool elems, int mode);

    delegate void ReleaseByteArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.LPArray)] byte[] elems, int mode);

    delegate void ReleaseCharArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.LPArray)] ushort[] elems, int mode);

    delegate void ReleaseShortArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.LPArray)] short[] elems, int mode);

    delegate void ReleaseIntArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.LPArray)] int[] elems, int mode);

    delegate void ReleaseLongArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.LPArray)] long[] elems, int mode);

    delegate void ReleaseFloatArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.LPArray)] float[] elems, int mode);

    delegate void ReleaseDoubleArrayElements
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.LPArray)] double[] elems, int mode);

    delegate void GetBooleanArrayRegion
        (IntPtr env, IntPtr array, int start, int l, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] buf);

    delegate void GetByteArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] buf);

    delegate void GetCharArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] buf);

    delegate void GetShortArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] short[] buf);

    delegate void GetIntArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] int[] buf);

    delegate void GetLongArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] long[] buf);

    delegate void GetFloatArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] float[] buf);

    delegate void GetDoubleArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] double[] buf);

    delegate void SetBooleanArrayRegion
        (IntPtr env, IntPtr array, int start, int l, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] buf);

    delegate void SetByteArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] byte[] buf);

    delegate void SetCharArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] buf);

    delegate void SetShortArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] short[] buf);

    delegate void SetIntArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] int[] buf);

    delegate void SetLongArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] long[] buf);

    delegate void SetFloatArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] float[] buf);

    delegate void SetDoubleArrayRegion
    (IntPtr env, IntPtr array, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] double[] buf);

    delegate int RegisterNatives
    (IntPtr env, IntPtr clazz, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] JniNativeMethod[] methods,
        int nMethods);

    delegate int UnregisterNatives
        (IntPtr env, IntPtr clazz);

    delegate int MonitorEnter
        (IntPtr env, IntPtr obj);

    delegate int MonitorExit
        (IntPtr env, IntPtr obj);

    delegate int GetJavaVm
        (IntPtr env, out JavaVm vm);

    delegate void GetStringRegion
    (IntPtr env, IntPtr str, int start, int len,
        [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] ushort[] buf);

    delegate void GetStringUtfRegion
        (IntPtr env, IntPtr str, int start, int len, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] char[] buf);

    delegate IntPtr GetPrimitiveArrayCritical
        (IntPtr env, IntPtr array, [MarshalAs(UnmanagedType.U1)] ref bool isCopy);

    delegate void ReleasePrimitiveArrayCritical
        (IntPtr env, IntPtr array, IntPtr carray, int mode);

    [return: MarshalAs(UnmanagedType.LPArray)]
    delegate byte[] GetStringCritical
        (IntPtr env, IntPtr str, [MarshalAs(UnmanagedType.U1)] ref bool isCopy);

    delegate void ReleaseStringCritical
        (IntPtr env, IntPtr str, [MarshalAs(UnmanagedType.LPArray)] byte[] utf);

    delegate IntPtr NewWeakGlobalRef
        (IntPtr env, IntPtr obj);

    delegate void DeleteWeakGlobalRef
        (IntPtr env, IntPtr r);

    [return: MarshalAs(UnmanagedType.U1)]
    delegate bool ExceptionCheck
        (IntPtr env);

    delegate IntPtr NewDirectByteBuffer
        (IntPtr env, IntPtr address, long capacity);

    delegate IntPtr GetDirectBufferAddress
        (IntPtr env, IntPtr buf);

    delegate long GetDirectBufferCapacity
        (IntPtr env, IntPtr buf);

    /* New JNI 1.6 Features */

    delegate JobjectRefType GetObjectRefType
        (IntPtr env, IntPtr obj);
}