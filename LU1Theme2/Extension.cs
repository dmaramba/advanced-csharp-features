using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LU1Theme2
{
    public static class Extension
    {

        //the length of a string
        public static int GetLength(this string value)
        {
            return value.Length;
        }

        //clean a string variable
        public static string ReplaceSpecialCharacters(this string value)
        {
            value = value.Replace("@", "");
            value = value.Replace("#", "");
            value = value.Replace("%", "");
            value = value.Replace("$", "");
            value = value.Replace("*", "");
            value = value.Replace("+", "");
            value = value.Replace("!", "");
            return value;
        }

        public static bool IsNumeric(this string value)
        {
            if (Int32.TryParse(value, out _)) return true;
            return false;
        }

        public static string ToCurrency(this double amount, string culture)
        {
            return string.Format(new CultureInfo(culture), "{0:C}", amount);
        }

    }
}
