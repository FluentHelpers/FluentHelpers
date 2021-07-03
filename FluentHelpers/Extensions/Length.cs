using System;
using System.Collections.Generic;
using System.Text;

namespace FluentHelpers
{
    public static class LengthExtensions
    {
        public static int LengthOnly(this string value, char only)
        {
            int length = 0;
            foreach (char c in value)
                if (c == only) length++;
            return length;
        }

        public static bool LengthMax(this string value, int max)
        {
            return (value.Length <= max) ? true : false ;
        }

        public static bool LengthMin(this string value, int min)
        {
            return (value.Length >= min) ? true : false;
        }

        // LengthMaxOnly
        // LengthMinOnly

    }
}
