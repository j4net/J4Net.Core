using System.Text;

namespace JNet.Core.Util
{
    public static class StringExtensions
    {
        public static byte[] ToUtfBytes(this string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }
    }
}