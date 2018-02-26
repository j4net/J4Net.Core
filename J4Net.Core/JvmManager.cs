using System;
using System.Linq;
using System.Runtime.InteropServices;
using J4Net.Core.JNICore.Interface;
using J4Net.Core.JNICore.Library;

namespace J4Net.Core
{
    public class JvmManager
    {
        private static JavaVmWrapper vm;
        private static JvmLibrary jvmLibrary;
        [ThreadStatic] private static JniEnvWrapper env;

        private static JvmManager instance;
        private static readonly object monitor = new object();
        private const int JniVersion = 0x00010006;

        public static JvmManager INSTANCE
        {
            get
            {
                if (instance != null)
                {
                    return instance;
                }

                lock (monitor)
                {
                    if (instance == null)
                    {
                        instance = new JvmManager();
                    }

                    return instance;
                }
            }
        }

        private JvmManager()
        {
            var jvmDllPath = Environment.GetEnvironmentVariable("JVM_DLL_PATH");
            var options =
                Environment.GetEnvironmentVariable("JAVA_OPTS")?.Split(' ').Select(JavaOption.DefineProperty)
                    .ToArray() ?? new JavaOption[0];

            jvmLibrary = new JvmLibrary(LibraryLoader.LoadUnmanagedLibrary(jvmDllPath));

            var vmArgs = new JavaVmInitArgs();
            jvmLibrary.GetDefaultJavaVmInitArgs(ref vmArgs);
            vmArgs.Version = JniVersion;

            vmArgs.NOptions = options.Length;
            vmArgs.Options = Marshal.AllocHGlobal(vmArgs.NOptions * Marshal.SizeOf(typeof(JavaVmOption)));

            var vmArgsP = Marshal.AllocHGlobal(Marshal.SizeOf(vmArgs));
            try
            {
                var optionsLocation = 0;
                foreach (var currentOption in options)
                {
                    Marshal.StructureToPtr(currentOption.ActualOption,
                        vmArgs.Options + optionsLocation * Marshal.SizeOf(typeof(JavaVmOption)), false);
                    optionsLocation++;
                }

                Marshal.StructureToPtr(vmArgs, vmArgsP, false);
                unsafe
                {
                    IntPtr envP;
                    IntPtr vmP;

                    jvmLibrary.CreateJavaVm(&vmP, &envP, vmArgsP);
                    vm = new JavaVmWrapper(vmP);
                    env = new JniEnvWrapper(envP);
                }

                //todo register all
            }
            finally
            {
                Marshal.DestroyStructure(vmArgsP, typeof(JavaVmInitArgs));
                Marshal.FreeHGlobal(vmArgsP);
                Marshal.FreeHGlobal(vmArgs.Options);
            }
        }

        ~JvmManager()
        {
            if (jvmLibrary == null)
            {
                return;
            }

            var ret = vm.DestroyJavaVm();
            if (ret != 0)
            {
                throw new InvalidOperationException("JavaVM destruction failed - return value obtained: " + ret);
            }

            jvmLibrary.Dispose();
        }

        public JniEnvWrapper GetEnv()
        {
            if (env != null)
            {
                return env;
            }

            unsafe
            {
                IntPtr envP;

                vm.AttachCurrentThread(&envP, IntPtr.Zero);
                env = new JniEnvWrapper(envP);
                return env;
            }
        }
    }
}