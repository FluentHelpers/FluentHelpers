using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FluentHelpers
{
    public static class StringExtension
    {

        //public static string CamelCase(this string val)
        //{

        //    if (val == null) return val;

        //    // If there are 0 or 1 characters, just return the string.
        //    if (val == null || val.Length < 2)
        //        return val;

        //    // Split the string into words.
        //    string[] words = val.Split(  new char[] { }, StringSplitOptions.RemoveEmptyEntries);

        //    // Combine the words.
        //    string result = words[0].ToLower();
        //    for (int i = 1; i < words.Length; i++)
        //    {
        //        result +=
        //            words[i].Substring(0, 1).ToUpper() +
        //            words[i].Substring(1);
        //    }

        //    result = Regex.Replace(result, "_[a-z]", delegate (Match m)
        //    {
        //        return m.ToString().TrimStart('_').ToUpper();
        //    });

        //    return result;
        //}


        // Convert the string to Pascal case.
        public static string PascalCase(this string val)
        {
            // If there are 0 or 1 characters, just return the string.
            if (val == null) return val;
            if (val.Length < 2) return val.ToUpper();

            // Split the string into words.
            string[] words = val.Split(
                new char[] { },
                StringSplitOptions.RemoveEmptyEntries);

            // Combine the words.
            string result = "";
            foreach (string word in words)
            {
                result +=
                    word.Substring(0, 1).ToUpper() +
                    word.Substring(1);
            }

            return result;
        }


        /// <summary>
        /// mengecek sebuah string mengandung satu atau lebih dari sebuah list
        /// </summary>
        /// <param name="list">sebuah list untuk dibandingkan</param>
        /// <returns>
        ///  <para>true jika salah satu list terdapat di dalam string </para>  
        ///  <para> true jika salah satu list terdapat di dalam string  </para>
        /// </returns>
        public static bool Contains(this string value, IList<string> list)
        {
            
            return true;
        }




        
    }
}
