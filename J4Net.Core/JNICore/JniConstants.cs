using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J4Net.Core.JNICore
{
    public sealed class JniConstants
    {
        private JniConstants()
        {

        }

        public static readonly int JNI_OK = 0;
        public static readonly int JNI_ERR = -1;
        public static readonly int JNI_EDETACHED = -2;
        public static readonly int JNI_VERSION = 0x00010006;
    }
}
