using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FluentHelpers
{
    public static class CamelCaseExtensions
    {


        public static string CamelCase(this string value)
        {

            // return if NULL
            if (value == null || value.Length == 0 ) return value;

            // If there are 0 or 1 characters, just return the string.
            if (value.Length < 2) return value;

            // Split the string into words.
            string[] words = value.Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);

            // Combine the words.
            string result = words[0].ToLower();
            for (int i = 1; i < words.Length; i++)
            {
                result +=
                    words[i].Substring(0, 1).ToUpper() +
                    words[i].Substring(1);
            }

            return result;
        }


       
      
    }
}
