using System;
using System.Runtime.InteropServices;

namespace JNet.Core.JNICore.Interface
{
    [StructLayout(LayoutKind.Explicit)]
    public struct JValue
    {
        [FieldOffset(0)] private bool booleanValue;
        [FieldOffset(0)] private byte byteValue;
        [FieldOffset(0)] private char charValue;
        [FieldOffset(0)] private short shortValue;
        [FieldOffset(0)] private int integerValue;
        [FieldOffset(0)] private long longValue;
        [FieldOffset(0)] private float floatValue;
        [FieldOffset(0)] private double doubleValue;
        [FieldOffset(0)] private IntPtr pointerVlaue;

        public bool BooleanValue
        {
            set { booleanValue = value; }
        }

        public byte ByteValue
        {
            set { byteValue = value; }
        }

        public char CharValue
        {
            set { charValue = value; }
        }

        public short ShortValue
        {
            set { shortValue = value; }
        }

        public int IntegerValue
        {
            set { integerValue = value; }
        }

        public long LongValue
        {
            set { longValue = value; }
        }

        public float FloatValue
        {
            set { floatValue = value; }
        }

        public double DoubleValue
        {
            set { doubleValue = value; }
        }

        public IntPtr PointerValue
        {
            set { pointerVlaue = value; }
        }
    }
}