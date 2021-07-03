using System;
using System.Collections.Generic;
using System.Text;

namespace FluentHelpers
{
    public static class StringToExtensions
    {
        public static int ToInt(this string value, int defaultValue = 0)
        {
            bool result = int.TryParse(value, out int number);
            if (result) { return number; }
            return defaultValue;
        }

        public static short ToShort(this string value, short defaultValue = 0)
        {
            bool result = short.TryParse(value, out short number);
            if (result) { return number; }
            return defaultValue;
        }

        public static long ToLong(this string value, long defaultValue = 0)
        {
            bool result = long.TryParse(value, out long number);
            if (result) { return number; }
            return defaultValue;

        }

    }
}
