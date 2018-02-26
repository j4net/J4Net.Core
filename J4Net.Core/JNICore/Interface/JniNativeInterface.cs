using System;
using System.Runtime.InteropServices;

namespace J4Net.Core.JNICore.Interface
{
    [StructLayout(LayoutKind.Sequential)]
    public struct JniNativeInterface
    {
        private readonly IntPtr reserved0;
        private readonly IntPtr reserved1;
        private readonly IntPtr reserved2;
        private readonly IntPtr reserved3;

        private readonly IntPtr GetVersion;
        private readonly IntPtr DefineClass;
        private readonly IntPtr FindClass;
        private readonly IntPtr FromReflectedMethod;
        private readonly IntPtr FromReflectedField;
        private readonly IntPtr ToReflectedMethod;
        private readonly IntPtr GetSuperclass;
        private readonly IntPtr IsAssignableFrom;
        private readonly IntPtr ToReflectedField;
        private readonly IntPtr Throw;
        private readonly IntPtr ThrowNew;
        private readonly IntPtr ExceptionOccurred;
        private readonly IntPtr ExceptionDescribe;
        private readonly IntPtr ExceptionClear;
        private readonly IntPtr FatalError;
        private readonly IntPtr PushLocalFrame;
        private readonly IntPtr PopLocalFrame;
        private readonly IntPtr NewGlobalRef;
        private readonly IntPtr DeleteGlobalRef;
        private readonly IntPtr DeleteLocalRef;
        private readonly IntPtr IsSameObject;
        private readonly IntPtr NewLocalRef;
        private readonly IntPtr EnsureLocalCapacity;
        private readonly IntPtr AllocObject;
        private readonly IntPtr NewObject;
        private readonly IntPtr NewObjectV;
        private readonly IntPtr NewObjectA;
        private readonly IntPtr GetObjectClass;
        private readonly IntPtr IsInstanceOf;
        private readonly IntPtr GetMethodID;
        private readonly IntPtr CallObjectMethod;
        private readonly IntPtr CallObjectMethodV;
        private readonly IntPtr CallObjectMethodA;
        private readonly IntPtr CallBooleanMethod;
        private readonly IntPtr CallBooleanMethodV;
        private readonly IntPtr CallBooleanMethodA;
        private readonly IntPtr CallByteMethod;
        private readonly IntPtr CallByteMethodV;
        private readonly IntPtr CallByteMethodA;
        private readonly IntPtr CallCharMethod;
        private readonly IntPtr CallCharMethodV;
        private readonly IntPtr CallCharMethodA;
        private readonly IntPtr CallShortMethod;
        private readonly IntPtr CallShortMethodV;
        private readonly IntPtr CallShortMethodA;
        private readonly IntPtr CallIntMethod;
        private readonly IntPtr CallIntMethodV;
        private readonly IntPtr CallIntMethodA;
        private readonly IntPtr CallLongMethod;
        private readonly IntPtr CallLongMethodV;
        private readonly IntPtr CallLongMethodA;
        private readonly IntPtr CallFloatMethod;
        private readonly IntPtr CallFloatMethodV;
        private readonly IntPtr CallFloatMethodA;
        private readonly IntPtr CallDoubleMethod;
        private readonly IntPtr CallDoubleMethodV;
        private readonly IntPtr CallDoubleMethodA;
        private readonly IntPtr CallVoidMethod;
        private readonly IntPtr CallVoidMethodV;
        private readonly IntPtr CallVoidMethodA;
        private readonly IntPtr CallNonvirtualObjectMethod;
        private readonly IntPtr CallNonvirtualObjectMethodV;
        private readonly IntPtr CallNonvirtualObjectMethodA;
        private readonly IntPtr CallNonvirtualBooleanMethod;
        private readonly IntPtr CallNonvirtualBooleanMethodV;
        private readonly IntPtr CallNonvirtualBooleanMethodA;
        private readonly IntPtr CallNonvirtualByteMethod;
        private readonly IntPtr CallNonvirtualByteMethodV;
        private readonly IntPtr CallNonvirtualByteMethodA;
        private readonly IntPtr CallNonvirtualCharMethod;
        private readonly IntPtr CallNonvirtualCharMethodV;
        private readonly IntPtr CallNonvirtualCharMethodA;
        private readonly IntPtr CallNonvirtualShortMethod;
        private readonly IntPtr CallNonvirtualShortMethodV;
        private readonly IntPtr CallNonvirtualShortMethodA;
        private readonly IntPtr CallNonvirtualIntMethod;
        private readonly IntPtr CallNonvirtualIntMethodV;
        private readonly IntPtr CallNonvirtualIntMethodA;
        private readonly IntPtr CallNonvirtualLongMethod;
        private readonly IntPtr CallNonvirtualLongMethodV;
        private readonly IntPtr CallNonvirtualLongMethodA;
        private readonly IntPtr CallNonvirtualFloatMethod;
        private readonly IntPtr CallNonvirtualFloatMethodV;
        private readonly IntPtr CallNonvirtualFloatMethodA;
        private readonly IntPtr CallNonvirtualDoubleMethod;
        private readonly IntPtr CallNonvirtualDoubleMethodV;
        private readonly IntPtr CallNonvirtualDoubleMethodA;
        private readonly IntPtr CallNonvirtualVoidMethod;
        private readonly IntPtr CallNonvirtualVoidMethodV;
        private readonly IntPtr CallNonvirtualVoidMethodA;
        private readonly IntPtr GetFieldID;
        private readonly IntPtr GetObjectField;
        private readonly IntPtr GetBooleanField;
        private readonly IntPtr GetByteField;
        private readonly IntPtr GetCharField;
        private readonly IntPtr GetShortField;
        private readonly IntPtr GetIntField;
        private readonly IntPtr GetLongField;
        private readonly IntPtr GetFloatField;
        private readonly IntPtr GetDoubleField;
        private readonly IntPtr SetObjectField;
        private readonly IntPtr SetBooleanField;
        private readonly IntPtr SetByteField;
        private readonly IntPtr SetCharField;
        private readonly IntPtr SetShortField;
        private readonly IntPtr SetIntField;
        private readonly IntPtr SetLongField;
        private readonly IntPtr SetFloatField;
        private readonly IntPtr SetDoubleField;
        private readonly IntPtr GetStaticMethodID;
        private readonly IntPtr CallStaticObjectMethod;
        private readonly IntPtr CallStaticObjectMethodV;
        private readonly IntPtr CallStaticObjectMethodA;
        private readonly IntPtr CallStaticBooleanMethod;
        private readonly IntPtr CallStaticBooleanMethodV;
        private readonly IntPtr CallStaticBooleanMethodA;
        private readonly IntPtr CallStaticByteMethod;
        private readonly IntPtr CallStaticByteMethodV;
        private readonly IntPtr CallStaticByteMethodA;
        private readonly IntPtr CallStaticCharMethod;
        private readonly IntPtr CallStaticCharMethodV;
        private readonly IntPtr CallStaticCharMethodA;
        private readonly IntPtr CallStaticShortMethod;
        private readonly IntPtr CallStaticShortMethodV;
        private readonly IntPtr CallStaticShortMethodA;
        private readonly IntPtr CallStaticIntMethod;
        private readonly IntPtr CallStaticIntMethodV;
        private readonly IntPtr CallStaticIntMethodA;
        private readonly IntPtr CallStaticLongMethod;
        private readonly IntPtr CallStaticLongMethodV;
        private readonly IntPtr CallStaticLongMethodA;
        private readonly IntPtr CallStaticFloatMethod;
        private readonly IntPtr CallStaticFloatMethodV;
        private readonly IntPtr CallStaticFloatMethodA;
        private readonly IntPtr CallStaticDoubleMethod;
        private readonly IntPtr CallStaticDoubleMethodV;
        private readonly IntPtr CallStaticDoubleMethodA;
        private readonly IntPtr CallStaticVoidMethod;
        private readonly IntPtr CallStaticVoidMethodV;
        private readonly IntPtr CallStaticVoidMethodA;
        private readonly IntPtr GetStaticFieldID;
        private readonly IntPtr GetStaticObjectField;
        private readonly IntPtr GetStaticBooleanField;
        private readonly IntPtr GetStaticByteField;
        private readonly IntPtr GetStaticCharField;
        private readonly IntPtr GetStaticShortField;
        private readonly IntPtr GetStaticIntField;
        private readonly IntPtr GetStaticLongField;
        private readonly IntPtr GetStaticFloatField;
        private readonly IntPtr GetStaticDoubleField;
        private readonly IntPtr SetStaticObjectField;
        private readonly IntPtr SetStaticBooleanField;
        private readonly IntPtr SetStaticByteField;
        private readonly IntPtr SetStaticCharField;
        private readonly IntPtr SetStaticShortField;
        private readonly IntPtr SetStaticIntField;
        private readonly IntPtr SetStaticLongField;
        private readonly IntPtr SetStaticFloatField;
        private readonly IntPtr SetStaticDoubleField;
        private readonly IntPtr NewString;
        private readonly IntPtr GetStringLength;
        private readonly IntPtr GetStringChars;
        private readonly IntPtr ReleaseStringChars;
        private readonly IntPtr NewStringUTF;
        private readonly IntPtr GetStringUTFLength;
        private readonly IntPtr GetStringUTFChars;
        private readonly IntPtr ReleaseStringUTFChars;
        private readonly IntPtr GetArrayLength;
        private readonly IntPtr NewObjectArray;
        private readonly IntPtr GetObjectArrayElement;
        private readonly IntPtr SetObjectArrayElement;
        private readonly IntPtr NewBooleanArray;
        private readonly IntPtr NewByteArray;
        private readonly IntPtr NewCharArray;
        private readonly IntPtr NewShortArray;
        private readonly IntPtr NewIntArray;
        private readonly IntPtr NewLongArray;
        private readonly IntPtr NewFloatArray;
        private readonly IntPtr NewDoubleArray;
        private readonly IntPtr GetBooleanArrayElements;
        private readonly IntPtr GetByteArrayElements;
        private readonly IntPtr GetCharArrayElements;
        private readonly IntPtr GetShortArrayElements;
        private readonly IntPtr GetIntArrayElements;
        private readonly IntPtr GetLongArrayElements;
        private readonly IntPtr GetFloatArrayElements;
        private readonly IntPtr GetDoubleArrayElements;
        private readonly IntPtr ReleaseBooleanArrayElements;
        private readonly IntPtr ReleaseByteArrayElements;
        private readonly IntPtr ReleaseCharArrayElements;
        private readonly IntPtr ReleaseShortArrayElements;
        private readonly IntPtr ReleaseIntArrayElements;
        private readonly IntPtr ReleaseLongArrayElements;
        private readonly IntPtr ReleaseFloatArrayElements;
        private readonly IntPtr ReleaseDoubleArrayElements;
        private readonly IntPtr GetBooleanArrayRegion;
        private readonly IntPtr GetByteArrayRegion;
        private readonly IntPtr GetCharArrayRegion;
        private readonly IntPtr GetShortArrayRegion;
        private readonly IntPtr GetIntArrayRegion;
        private readonly IntPtr GetLongArrayRegion;
        private readonly IntPtr GetFloatArrayRegion;
        private readonly IntPtr GetDoubleArrayRegion;
        private readonly IntPtr SetBooleanArrayRegion;
        private readonly IntPtr SetByteArrayRegion;
        private readonly IntPtr SetCharArrayRegion;
        private readonly IntPtr SetShortArrayRegion;
        private readonly IntPtr SetIntArrayRegion;
        private readonly IntPtr SetLongArrayRegion;
        private readonly IntPtr SetFloatArrayRegion;
        private readonly IntPtr SetDoubleArrayRegion;
        private readonly IntPtr RegisterNatives;
        private readonly IntPtr UnregisterNatives;
        private readonly IntPtr MonitorEnter;
        private readonly IntPtr MonitorExit;
        private readonly IntPtr GetJavaVM;
        private readonly IntPtr GetStringRegion;
        private readonly IntPtr GetStringUTFRegion;
        private readonly IntPtr GetPrimitiveArrayCritical;
        private readonly IntPtr ReleasePrimitiveArrayCritical;
        private readonly IntPtr GetStringCritical;
        private readonly IntPtr ReleaseStringCritical;
        private readonly IntPtr NewWeakGlobalRef;
        private readonly IntPtr DeleteWeakGlobalRef;
        private readonly IntPtr ExceptionCheck;
        private readonly IntPtr NewDirectByteBuffer;
        private readonly IntPtr GetDirectBufferAddress;
        private readonly IntPtr GetDirectBufferCapacity;
        private readonly IntPtr GetObjectRefType;

        public IntPtr GetVersionPtr
        {
            get { return GetVersion; }
        }

        public IntPtr DefineClassPtr
        {
            get { return DefineClass; }
        }

        public IntPtr FindClassPtr
        {
            get { return FindClass; }
        }

        public IntPtr FromReflectedMethodPtr
        {
            get { return FromReflectedMethod; }
        }

        public IntPtr FromReflectedFieldPtr
        {
            get { return FromReflectedField; }
        }

        public IntPtr ToReflectedMethodPtr
        {
            get { return ToReflectedMethod; }
        }

        public IntPtr GetSuperclassPtr
        {
            get { return GetSuperclass; }
        }

        public IntPtr IsAssignableFromPtr
        {
            get { return IsAssignableFrom; }
        }

        public IntPtr ToReflectedFieldPtr
        {
            get { return ToReflectedField; }
        }

        public IntPtr ThrowPtr
        {
            get { return Throw; }
        }

        public IntPtr ThrowNewPtr
        {
            get { return ThrowNew; }
        }

        public IntPtr ExceptionOccurredPtr
        {
            get { return ExceptionOccurred; }
        }

        public IntPtr ExceptionDescribePtr
        {
            get { return ExceptionDescribe; }
        }

        public IntPtr ExceptionClearPtr
        {
            get { return ExceptionClear; }
        }

        public IntPtr FatalErrorPtr
        {
            get { return FatalError; }
        }

        public IntPtr PushLocalFramePtr
        {
            get { return PushLocalFrame; }
        }

        public IntPtr PopLocalFramePtr
        {
            get { return PopLocalFrame; }
        }

        public IntPtr NewGlobalRefPtr
        {
            get { return NewGlobalRef; }
        }

        public IntPtr DeleteGlobalRefPtr
        {
            get { return DeleteGlobalRef; }
        }

        public IntPtr DeleteLocalRefPtr
        {
            get { return DeleteLocalRef; }
        }

        public IntPtr IsSameObjectPtr
        {
            get { return IsSameObject; }
        }

        public IntPtr NewLocalRefPtr
        {
            get { return NewLocalRef; }
        }

        public IntPtr EnsureLocalCapacityPtr
        {
            get { return EnsureLocalCapacity; }
        }

        public IntPtr AllocObjectPtr
        {
            get { return AllocObject; }
        }

        public IntPtr NewObjectPtr
        {
            get { return NewObject; }
        }

        public IntPtr NewObjectVPtr
        {
            get { return NewObjectV; }
        }

        public IntPtr NewObjectAPtr
        {
            get { return NewObjectA; }
        }

        public IntPtr GetObjectClassPtr
        {
            get { return GetObjectClass; }
        }

        public IntPtr IsInstanceOfPtr
        {
            get { return IsInstanceOf; }
        }

        public IntPtr GetMethodIDPtr
        {
            get { return GetMethodID; }
        }

        public IntPtr CallObjectMethodPtr
        {
            get { return CallObjectMethod; }
        }

        public IntPtr CallObjectMethodVPtr
        {
            get { return CallObjectMethodV; }
        }

        public IntPtr CallObjectMethodAPtr
        {
            get { return CallObjectMethodA; }
        }

        public IntPtr CallBooleanMethodPtr
        {
            get { return CallBooleanMethod; }
        }

        public IntPtr CallBooleanMethodVPtr
        {
            get { return CallBooleanMethodV; }
        }

        public IntPtr CallBooleanMethodAPtr
        {
            get { return CallBooleanMethodA; }
        }

        public IntPtr CallByteMethodPtr
        {
            get { return CallByteMethod; }
        }

        public IntPtr CallByteMethodVPtr
        {
            get { return CallByteMethodV; }
        }

        public IntPtr CallByteMethodAPtr
        {
            get { return CallByteMethodA; }
        }

        public IntPtr CallCharMethodPtr
        {
            get { return CallCharMethod; }
        }

        public IntPtr CallCharMethodVPtr
        {
            get { return CallCharMethodV; }
        }

        public IntPtr CallCharMethodAPtr
        {
            get { return CallCharMethodA; }
        }

        public IntPtr CallShortMethodPtr
        {
            get { return CallShortMethod; }
        }

        public IntPtr CallShortMethodVPtr
        {
            get { return CallShortMethodV; }
        }

        public IntPtr CallShortMethodAPtr
        {
            get { return CallShortMethodA; }
        }

        public IntPtr CallIntMethodPtr
        {
            get { return CallIntMethod; }
        }

        public IntPtr CallIntMethodVPtr
        {
            get { return CallIntMethodV; }
        }

        public IntPtr CallIntMethodAPtr
        {
            get { return CallIntMethodA; }
        }

        public IntPtr CallLongMethodPtr
        {
            get { return CallLongMethod; }
        }

        public IntPtr CallLongMethodVPtr
        {
            get { return CallLongMethodV; }
        }

        public IntPtr CallLongMethodAPtr
        {
            get { return CallLongMethodA; }
        }

        public IntPtr CallFloatMethodPtr
        {
            get { return CallFloatMethod; }
        }

        public IntPtr CallFloatMethodVPtr
        {
            get { return CallFloatMethodV; }
        }

        public IntPtr CallFloatMethodAPtr
        {
            get { return CallFloatMethodA; }
        }

        public IntPtr CallDoubleMethodPtr
        {
            get { return CallDoubleMethod; }
        }

        public IntPtr CallDoubleMethodVPtr
        {
            get { return CallDoubleMethodV; }
        }

        public IntPtr CallDoubleMethodAPtr
        {
            get { return CallDoubleMethodA; }
        }

        public IntPtr CallVoidMethodPtr
        {
            get { return CallVoidMethod; }
        }

        public IntPtr CallVoidMethodVPtr
        {
            get { return CallVoidMethodV; }
        }

        public IntPtr CallVoidMethodAPtr
        {
            get { return CallVoidMethodA; }
        }

        public IntPtr CallNonvirtualObjectMethodPtr
        {
            get { return CallNonvirtualObjectMethod; }
        }

        public IntPtr CallNonvirtualObjectMethodVPtr
        {
            get { return CallNonvirtualObjectMethodV; }
        }

        public IntPtr CallNonvirtualObjectMethodAPtr
        {
            get { return CallNonvirtualObjectMethodA; }
        }

        public IntPtr CallNonvirtualBooleanMethodPtr
        {
            get { return CallNonvirtualBooleanMethod; }
        }

        public IntPtr CallNonvirtualBooleanMethodVPtr
        {
            get { return CallNonvirtualBooleanMethodV; }
        }

        public IntPtr CallNonvirtualBooleanMethodAPtr
        {
            get { return CallNonvirtualBooleanMethodA; }
        }

        public IntPtr CallNonvirtualByteMethodPtr
        {
            get { return CallNonvirtualByteMethod; }
        }

        public IntPtr CallNonvirtualByteMethodVPtr
        {
            get { return CallNonvirtualByteMethodV; }
        }

        public IntPtr CallNonvirtualByteMethodAPtr
        {
            get { return CallNonvirtualByteMethodA; }
        }

        public IntPtr CallNonvirtualCharMethodPtr
        {
            get { return CallNonvirtualCharMethod; }
        }

        public IntPtr CallNonvirtualCharMethodVPtr
        {
            get { return CallNonvirtualCharMethodV; }
        }

        public IntPtr CallNonvirtualCharMethodAPtr
        {
            get { return CallNonvirtualCharMethodA; }
        }

        public IntPtr CallNonvirtualShortMethodPtr
        {
            get { return CallNonvirtualShortMethod; }
        }

        public IntPtr CallNonvirtualShortMethodVPtr
        {
            get { return CallNonvirtualShortMethodV; }
        }

        public IntPtr CallNonvirtualShortMethodAPtr
        {
            get { return CallNonvirtualShortMethodA; }
        }

        public IntPtr CallNonvirtualIntMethodPtr
        {
            get { return CallNonvirtualIntMethod; }
        }

        public IntPtr CallNonvirtualIntMethodVPtr
        {
            get { return CallNonvirtualIntMethodV; }
        }

        public IntPtr CallNonvirtualIntMethodAPtr
        {
            get { return CallNonvirtualIntMethodA; }
        }

        public IntPtr CallNonvirtualLongMethodPtr
        {
            get { return CallNonvirtualLongMethod; }
        }

        public IntPtr CallNonvirtualLongMethodVPtr
        {
            get { return CallNonvirtualLongMethodV; }
        }

        public IntPtr CallNonvirtualLongMethodAPtr
        {
            get { return CallNonvirtualLongMethodA; }
        }

        public IntPtr CallNonvirtualFloatMethodPtr
        {
            get { return CallNonvirtualFloatMethod; }
        }

        public IntPtr CallNonvirtualFloatMethodVPtr
        {
            get { return CallNonvirtualFloatMethodV; }
        }

        public IntPtr CallNonvirtualFloatMethodAPtr
        {
            get { return CallNonvirtualFloatMethodA; }
        }

        public IntPtr CallNonvirtualDoubleMethodPtr
        {
            get { return CallNonvirtualDoubleMethod; }
        }

        public IntPtr CallNonvirtualDoubleMethodVPtr
        {
            get { return CallNonvirtualDoubleMethodV; }
        }

        public IntPtr CallNonvirtualDoubleMethodAPtr
        {
            get { return CallNonvirtualDoubleMethodA; }
        }

        public IntPtr CallNonvirtualVoidMethodPtr
        {
            get { return CallNonvirtualVoidMethod; }
        }

        public IntPtr CallNonvirtualVoidMethodVPtr
        {
            get { return CallNonvirtualVoidMethodV; }
        }

        public IntPtr CallNonvirtualVoidMethodAPtr
        {
            get { return CallNonvirtualVoidMethodA; }
        }

        public IntPtr GetFieldIDPtr
        {
            get { return GetFieldID; }
        }

        public IntPtr GetObjectFieldPtr
        {
            get { return GetObjectField; }
        }

        public IntPtr GetBooleanFieldPtr
        {
            get { return GetBooleanField; }
        }

        public IntPtr GetByteFieldPtr
        {
            get { return GetByteField; }
        }

        public IntPtr GetCharFieldPtr
        {
            get { return GetCharField; }
        }

        public IntPtr GetShortFieldPtr
        {
            get { return GetShortField; }
        }

        public IntPtr GetIntFieldPtr
        {
            get { return GetIntField; }
        }

        public IntPtr GetLongFieldPtr
        {
            get { return GetLongField; }
        }

        public IntPtr GetFloatFieldPtr
        {
            get { return GetFloatField; }
        }

        public IntPtr GetDoubleFieldPtr
        {
            get { return GetDoubleField; }
        }

        public IntPtr SetObjectFieldPtr
        {
            get { return SetObjectField; }
        }

        public IntPtr SetBooleanFieldPtr
        {
            get { return SetBooleanField; }
        }

        public IntPtr SetByteFieldPtr
        {
            get { return SetByteField; }
        }

        public IntPtr SetCharFieldPtr
        {
            get { return SetCharField; }
        }

        public IntPtr SetShortFieldPtr
        {
            get { return SetShortField; }
        }

        public IntPtr SetIntFieldPtr
        {
            get { return SetIntField; }
        }

        public IntPtr SetLongFieldPtr
        {
            get { return SetLongField; }
        }

        public IntPtr SetFloatFieldPtr
        {
            get { return SetFloatField; }
        }

        public IntPtr SetDoubleFieldPtr
        {
            get { return SetDoubleField; }
        }

        public IntPtr GetStaticMethodIDPtr
        {
            get { return GetStaticMethodID; }
        }

        public IntPtr CallStaticObjectMethodPtr
        {
            get { return CallStaticObjectMethod; }
        }

        public IntPtr CallStaticObjectMethodVPtr
        {
            get { return CallStaticObjectMethodV; }
        }

        public IntPtr CallStaticObjectMethodAPtr
        {
            get { return CallStaticObjectMethodA; }
        }

        public IntPtr CallStaticBooleanMethodPtr
        {
            get { return CallStaticBooleanMethod; }
        }

        public IntPtr CallStaticBooleanMethodVPtr
        {
            get { return CallStaticBooleanMethodV; }
        }

        public IntPtr CallStaticBooleanMethodAPtr
        {
            get { return CallStaticBooleanMethodA; }
        }

        public IntPtr CallStaticByteMethodPtr
        {
            get { return CallStaticByteMethod; }
        }

        public IntPtr CallStaticByteMethodVPtr
        {
            get { return CallStaticByteMethodV; }
        }

        public IntPtr CallStaticByteMethodAPtr
        {
            get { return CallStaticByteMethodA; }
        }

        public IntPtr CallStaticCharMethodPtr
        {
            get { return CallStaticCharMethod; }
        }

        public IntPtr CallStaticCharMethodVPtr
        {
            get { return CallStaticCharMethodV; }
        }

        public IntPtr CallStaticCharMethodAPtr
        {
            get { return CallStaticCharMethodA; }
        }

        public IntPtr CallStaticShortMethodPtr
        {
            get { return CallStaticShortMethod; }
        }

        public IntPtr CallStaticShortMethodVPtr
        {
            get { return CallStaticShortMethodV; }
        }

        public IntPtr CallStaticShortMethodAPtr
        {
            get { return CallStaticShortMethodA; }
        }

        public IntPtr CallStaticIntMethodPtr
        {
            get { return CallStaticIntMethod; }
        }

        public IntPtr CallStaticIntMethodVPtr
        {
            get { return CallStaticIntMethodV; }
        }

        public IntPtr CallStaticIntMethodAPtr
        {
            get { return CallStaticIntMethodA; }
        }

        public IntPtr CallStaticLongMethodPtr
        {
            get { return CallStaticLongMethod; }
        }

        public IntPtr CallStaticLongMethodVPtr
        {
            get { return CallStaticLongMethodV; }
        }

        public IntPtr CallStaticLongMethodAPtr
        {
            get { return CallStaticLongMethodA; }
        }

        public IntPtr CallStaticFloatMethodPtr
        {
            get { return CallStaticFloatMethod; }
        }

        public IntPtr CallStaticFloatMethodVPtr
        {
            get { return CallStaticFloatMethodV; }
        }

        public IntPtr CallStaticFloatMethodAPtr
        {
            get { return CallStaticFloatMethodA; }
        }

        public IntPtr CallStaticDoubleMethodPtr
        {
            get { return CallStaticDoubleMethod; }
        }

        public IntPtr CallStaticDoubleMethodVPtr
        {
            get { return CallStaticDoubleMethodV; }
        }

        public IntPtr CallStaticDoubleMethodAPtr
        {
            get { return CallStaticDoubleMethodA; }
        }

        public IntPtr CallStaticVoidMethodPtr
        {
            get { return CallStaticVoidMethod; }
        }

        public IntPtr CallStaticVoidMethodVPtr
        {
            get { return CallStaticVoidMethodV; }
        }

        public IntPtr CallStaticVoidMethodAPtr
        {
            get { return CallStaticVoidMethodA; }
        }

        public IntPtr GetStaticFieldIDPtr
        {
            get { return GetStaticFieldID; }
        }

        public IntPtr GetStaticObjectFieldPtr
        {
            get { return GetStaticObjectField; }
        }

        public IntPtr GetStaticBooleanFieldPtr
        {
            get { return GetStaticBooleanField; }
        }

        public IntPtr GetStaticByteFieldPtr
        {
            get { return GetStaticByteField; }
        }

        public IntPtr GetStaticCharFieldPtr
        {
            get { return GetStaticCharField; }
        }

        public IntPtr GetStaticShortFieldPtr
        {
            get { return GetStaticShortField; }
        }

        public IntPtr GetStaticIntFieldPtr
        {
            get { return GetStaticIntField; }
        }

        public IntPtr GetStaticLongFieldPtr
        {
            get { return GetStaticLongField; }
        }

        public IntPtr GetStaticFloatFieldPtr
        {
            get { return GetStaticFloatField; }
        }

        public IntPtr GetStaticDoubleFieldPtr
        {
            get { return GetStaticDoubleField; }
        }

        public IntPtr SetStaticObjectFieldPtr
        {
            get { return SetStaticObjectField; }
        }

        public IntPtr SetStaticBooleanFieldPtr
        {
            get { return SetStaticBooleanField; }
        }

        public IntPtr SetStaticByteFieldPtr
        {
            get { return SetStaticByteField; }
        }

        public IntPtr SetStaticCharFieldPtr
        {
            get { return SetStaticCharField; }
        }

        public IntPtr SetStaticShortFieldPtr
        {
            get { return SetStaticShortField; }
        }

        public IntPtr SetStaticIntFieldPtr
        {
            get { return SetStaticIntField; }
        }

        public IntPtr SetStaticLongFieldPtr
        {
            get { return SetStaticLongField; }
        }

        public IntPtr SetStaticFloatFieldPtr
        {
            get { return SetStaticFloatField; }
        }

        public IntPtr SetStaticDoubleFieldPtr
        {
            get { return SetStaticDoubleField; }
        }

        public IntPtr NewStringPtr
        {
            get { return NewString; }
        }

        public IntPtr GetStringLengthPtr
        {
            get { return GetStringLength; }
        }

        public IntPtr GetStringCharsPtr
        {
            get { return GetStringChars; }
        }

        public IntPtr ReleaseStringCharsPtr
        {
            get { return ReleaseStringChars; }
        }

        public IntPtr NewStringUTFPtr
        {
            get { return NewStringUTF; }
        }

        public IntPtr GetStringUTFLengthPtr
        {
            get { return GetStringUTFLength; }
        }

        public IntPtr GetStringUTFCharsPtr
        {
            get { return GetStringUTFChars; }
        }

        public IntPtr ReleaseStringUTFCharsPtr
        {
            get { return ReleaseStringUTFChars; }
        }

        public IntPtr GetArrayLengthPtr
        {
            get { return GetArrayLength; }
        }

        public IntPtr NewObjectArrayPtr
        {
            get { return NewObjectArray; }
        }

        public IntPtr GetObjectArrayElementPtr
        {
            get { return GetObjectArrayElement; }
        }

        public IntPtr SetObjectArrayElementPtr
        {
            get { return SetObjectArrayElement; }
        }

        public IntPtr NewBooleanArrayPtr
        {
            get { return NewBooleanArray; }
        }

        public IntPtr NewByteArrayPtr
        {
            get { return NewByteArray; }
        }

        public IntPtr NewCharArrayPtr
        {
            get { return NewCharArray; }
        }

        public IntPtr NewShortArrayPtr
        {
            get { return NewShortArray; }
        }

        public IntPtr NewIntArrayPtr
        {
            get { return NewIntArray; }
        }

        public IntPtr NewLongArrayPtr
        {
            get { return NewLongArray; }
        }

        public IntPtr NewFloatArrayPtr
        {
            get { return NewFloatArray; }
        }

        public IntPtr NewDoubleArrayPtr
        {
            get { return NewDoubleArray; }
        }

        public IntPtr GetBooleanArrayElementsPtr
        {
            get { return GetBooleanArrayElements; }
        }

        public IntPtr GetByteArrayElementsPtr
        {
            get { return GetByteArrayElements; }
        }

        public IntPtr GetCharArrayElementsPtr
        {
            get { return GetCharArrayElements; }
        }

        public IntPtr GetShortArrayElementsPtr
        {
            get { return GetShortArrayElements; }
        }

        public IntPtr GetIntArrayElementsPtr
        {
            get { return GetIntArrayElements; }
        }

        public IntPtr GetLongArrayElementsPtr
        {
            get { return GetLongArrayElements; }
        }

        public IntPtr GetFloatArrayElementsPtr
        {
            get { return GetFloatArrayElements; }
        }

        public IntPtr GetDoubleArrayElementsPtr
        {
            get { return GetDoubleArrayElements; }
        }

        public IntPtr ReleaseBooleanArrayElementsPtr
        {
            get { return ReleaseBooleanArrayElements; }
        }

        public IntPtr ReleaseByteArrayElementsPtr
        {
            get { return ReleaseByteArrayElements; }
        }

        public IntPtr ReleaseCharArrayElementsPtr
        {
            get { return ReleaseCharArrayElements; }
        }

        public IntPtr ReleaseShortArrayElementsPtr
        {
            get { return ReleaseShortArrayElements; }
        }

        public IntPtr ReleaseIntArrayElementsPtr
        {
            get { return ReleaseIntArrayElements; }
        }

        public IntPtr ReleaseLongArrayElementsPtr
        {
            get { return ReleaseLongArrayElements; }
        }

        public IntPtr ReleaseFloatArrayElementsPtr
        {
            get { return ReleaseFloatArrayElements; }
        }

        public IntPtr ReleaseDoubleArrayElementsPtr
        {
            get { return ReleaseDoubleArrayElements; }
        }

        public IntPtr GetBooleanArrayRegionPtr
        {
            get { return GetBooleanArrayRegion; }
        }

        public IntPtr GetByteArrayRegionPtr
        {
            get { return GetByteArrayRegion; }
        }

        public IntPtr GetCharArrayRegionPtr
        {
            get { return GetCharArrayRegion; }
        }

        public IntPtr GetShortArrayRegionPtr
        {
            get { return GetShortArrayRegion; }
        }

        public IntPtr GetIntArrayRegionPtr
        {
            get { return GetIntArrayRegion; }
        }

        public IntPtr GetLongArrayRegionPtr
        {
            get { return GetLongArrayRegion; }
        }

        public IntPtr GetFloatArrayRegionPtr
        {
            get { return GetFloatArrayRegion; }
        }

        public IntPtr GetDoubleArrayRegionPtr
        {
            get { return GetDoubleArrayRegion; }
        }

        public IntPtr SetBooleanArrayRegionPtr
        {
            get { return SetBooleanArrayRegion; }
        }

        public IntPtr SetByteArrayRegionPtr
        {
            get { return SetByteArrayRegion; }
        }

        public IntPtr SetCharArrayRegionPtr
        {
            get { return SetCharArrayRegion; }
        }

        public IntPtr SetShortArrayRegionPtr
        {
            get { return SetShortArrayRegion; }
        }

        public IntPtr SetIntArrayRegionPtr
        {
            get { return SetIntArrayRegion; }
        }

        public IntPtr SetLongArrayRegionPtr
        {
            get { return SetLongArrayRegion; }
        }

        public IntPtr SetFloatArrayRegionPtr
        {
            get { return SetFloatArrayRegion; }
        }

        public IntPtr SetDoubleArrayRegionPtr
        {
            get { return SetDoubleArrayRegion; }
        }

        public IntPtr RegisterNativesPtr
        {
            get { return RegisterNatives; }
        }

        public IntPtr UnregisterNativesPtr
        {
            get { return UnregisterNatives; }
        }

        public IntPtr MonitorEnterPtr
        {
            get { return MonitorEnter; }
        }

        public IntPtr MonitorExitPtr
        {
            get { return MonitorExit; }
        }

        public IntPtr GetJavaVMPtr
        {
            get { return GetJavaVM; }
        }

        public IntPtr GetStringRegionPtr
        {
            get { return GetStringRegion; }
        }

        public IntPtr GetStringUTFRegionPtr
        {
            get { return GetStringUTFRegion; }
        }

        public IntPtr GetPrimitiveArrayCriticalPtr
        {
            get { return GetPrimitiveArrayCritical; }
        }

        public IntPtr ReleasePrimitiveArrayCriticalPtr
        {
            get { return ReleasePrimitiveArrayCritical; }
        }

        public IntPtr GetStringCriticalPtr
        {
            get { return GetStringCritical; }
        }

        public IntPtr ReleaseStringCriticalPtr
        {
            get { return ReleaseStringCritical; }
        }

        public IntPtr NewWeakGlobalRefPtr
        {
            get { return NewWeakGlobalRef; }
        }

        public IntPtr DeleteWeakGlobalRefPtr
        {
            get { return DeleteWeakGlobalRef; }
        }

        public IntPtr ExceptionCheckPtr
        {
            get { return ExceptionCheck; }
        }

        public IntPtr NewDirectByteBufferPtr
        {
            get { return NewDirectByteBuffer; }
        }

        public IntPtr GetDirectBufferAddressPtr
        {
            get { return GetDirectBufferAddress; }
        }

        public IntPtr GetDirectBufferCapacityPtr
        {
            get { return GetDirectBufferCapacity; }
        }

        public IntPtr GetObjectRefTypePtr
        {
            get { return GetObjectRefType; }
        }
    }
}