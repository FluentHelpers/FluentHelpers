using System;
using System.Collections.Generic;
using System.Text;

namespace FluentHelpers
{
    public static class IsGuidExtensions
    {
        public static bool IsGuid(this string value)
        {
            return Guid.TryParse(value, out Guid resultOut);

        }

    }
}
