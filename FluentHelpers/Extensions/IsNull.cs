using System;
using System.Collections.Generic;
using System.Text;

namespace FluentHelpers
{
    public static class IsNullExtensions
    {
        public static bool IsNullOrWhiteSpace(this string value) { return string.IsNullOrWhiteSpace(value); }
        public static bool IsNullOrEmpty(this string value) { return string.IsNullOrEmpty(value); }
        public static bool IsNull(this string value) { return (value == null); }


        public static bool IsNull(this int? value) { return (value == null); }
        public static bool IsNull(this byte? value) { return (value == null); }
        public static bool IsNull(this sbyte? value) { return (value == null); }
        public static bool IsNull(this short? value) { return (value == null); }
        public static bool IsNull(this ushort? value) { return (value == null); }
        public static bool IsNull(this uint? value) { return (value == null); }
        public static bool IsNull(this long? value) { return (value == null); }
        public static bool IsNull(this ulong? value) { return (value == null); }
        public static bool IsNull(this float? value) { return (value == null); }
        public static bool IsNull(this double? value) { return (value == null); }
        public static bool IsNull(this decimal? value) { return (value == null); }
        public static bool IsNull(this char? value) { return (value == null); }
        public static bool IsNull(this bool? value) { return (value == null); }

        public static bool IsNull(this Guid value) { return (value == Guid.Empty);  }
        public static bool IsNull(this Guid? value) { return (value == null);  }


        public static bool IsNull(this DateTime? value) { return (value == null); }

        public static bool IsNull<T>(this IList<T> value) { return (value == null); }
        public static bool IsNull<Tk, Tv>(this Dictionary<Tk, Tv> value) { return (value == null); }


    }
}
