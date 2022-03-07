using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{

    public static class StringExtensions
    {
        public static bool IsInteger(this string s)
        {
            return int.TryParse(s, out int _);
        }

        public static int ToInteger(this string s)
        {
            if (int.TryParse(s, out int integer))
                return integer;

            throw new ArgumentException(nameof(s));
        }

        public static List<int> ToInteger(this IEnumerable<string> strings)
        {
            return strings
                .Where(item => item.IsInteger())
                .Select(item => item.ToInteger())
                .ToList();
        }
    }
}
