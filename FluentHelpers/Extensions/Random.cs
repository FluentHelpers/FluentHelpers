using System;
using System.Collections.Generic;
using System.Text;

namespace FluentHelpers
{
    public static class random
    {
        private const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        private const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string NUMBERS = "123456789";
        private const string SPECIALS = @"~!@#$%^&*()";

        public static string String(int length, bool useUppercase = false, bool useNumbers = false, bool useSpecial = false) {
            char[] result = new char[length];
            StringBuilder source = new StringBuilder();
            source.Append(LOWER_CASE);
            System.Random _random = new Random();
            int counter;

			if (useUppercase) source.Append(UPPER_CAES);
			if (useNumbers) source.Append(NUMBERS);
			if (useSpecial) source.Append(SPECIALS);

            string sourceFinal = source.ToString();

            for (counter = 0; counter < length; counter++)
            {
                result[counter] = sourceFinal[_random.Next(source.Length - 1)];
            }

            return System.String.Join(null, result);
        }

        public static long Int(int length) {
            char[] result = new char[length];
            StringBuilder source = new StringBuilder();
            source.Append(NUMBERS);
            System.Random _random = new Random();
            int counter;

            string sourceFinal = source.ToString();

            for (counter = 0; counter < length; counter++)
            {
                result[counter] = sourceFinal[_random.Next(source.Length - 1)];
            }
            return System.String.Join(null, result).ToLong();
        }
    }
}
