using System.Globalization;
using JNet.Core.JNICore.Interface;

namespace JNet.Core
{
    public class JavaOption
    {
        private readonly JavaVmOption actualOption;

        private JavaOption(string optionString)
        {
            actualOption = new JavaVmOption(optionString);
        }

        public static JavaOption DefineProperty(string propertyName, string propertyValue)
        {
            return new JavaOption(string.Format(CultureInfo.InvariantCulture, "-D{0}={1}", propertyName,
                propertyValue));
        }

        public static JavaOption DefineProperty(string property)
        {
            return new JavaOption(property);
        }

        internal JavaVmOption ActualOption
        {
	        get { return actualOption; }
        }

	    public override string ToString()
        {
            return actualOption.OptionString;
        }
    }
}