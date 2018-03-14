using System.Text;

namespace J4Net.Core.Util
{
    public static class StringExtensions
    {
        public static byte[] ToUtfBytes(this string str)
        {
            int count = Encoding.UTF8.GetByteCount(str);
            byte[] utf = new byte[count + 1];
            Encoding.UTF8.GetBytes(str, 0, str.Length, utf, 0);
            return utf;
        }
    }
}