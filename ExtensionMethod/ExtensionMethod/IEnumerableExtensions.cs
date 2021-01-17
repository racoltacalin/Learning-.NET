using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    public static class IEnumerableExtensions
    {
        public static string ToString<T>(this IEnumerable<T> enumeration)
        {
            StringBuilder result = new StringBuilder();
            result.Append("[");

            foreach (var item in enumeration)
            {
                result.Append(item.ToString());
                result.Append(", ");
            }

            if (result.Length > 1)
            {
                result.Remove(result.Length - 2, 2);
            }
            result.Append("]");
            return result.ToString();
        }
    }
}
