using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spectra.Model.Client.Helpers
{
    public static class StringFormattingHelper
    {
        /// <summary>
        /// Returns the input string with the first character converted to uppercase
        /// </summary>
        public static string FirstLetterToUpperCase(this string s)
        {
            if (string.IsNullOrEmpty(s))
                throw new ArgumentException("There is no first letter");

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}
