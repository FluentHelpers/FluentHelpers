using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace FluentHelpers
{
    public static class SeparatorExtensions
    {
        public static string Separator(this string value, char Separator, int addEvery = 0)
        {

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < value.Length; i++)
            {
                if (i % addEvery == 0)
                    sb.Append(Separator);
                sb.Append(value[i]);
            }
            sb.Remove(0, 1);
            return sb.ToString();

        }

    }
}
