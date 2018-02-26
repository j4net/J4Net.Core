using System.Text;

namespace J4Net.Core.Util
{
    public static class StringExtensions
    {
        public static byte[] ToUtfBytes(this string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }
    }
}