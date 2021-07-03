using System;
using System.Collections.Generic;
using System.Text;

namespace FluentHelpers
{
    public static class Remove
    {
        // The Str::remove method removes the given value or array of values from the string:

        //        use Illuminate\Support\Str;

        //$string = 'Peter Piper picked a peck of pickled peppers.';

        //$removed = Str::remove('e', $string);

        //// Ptr Pipr pickd a pck of pickld ppprs.
        ///


        public static string RemovePreviousCharacterIsSame(this string value)
        {

            StringBuilder result = new StringBuilder();

            // convert to chart array
            char[] valueChar = value.ToCharArray();

            // remove duplication if previous character is same
            for (int i = 0; i < value.Length; i++)
            {
                // first char
                if (i == 0)
                {
                    result.Append(value[i]);
                }
                else
                {
                    if (value[i - 1] != value[i])
                    {
                        result.Append(value[i]);
                    }
                }


            }

            return result.ToString();
        }

    }
}
