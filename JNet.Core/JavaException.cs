using System;

namespace JNet.Core
{
    [Serializable]
    public class JavaException : Exception
    {
        private readonly string[] javaStackTrace = { };

        public JavaException()
        {
        }

        public JavaException(string message) : base(message)
        {
        }
    }
}