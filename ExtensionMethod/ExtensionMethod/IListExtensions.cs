using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethod
{
    public static class IListExtensions
    {
        public static void IncreaseWith(this IList<int> list, int amount)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += amount;
            }
        }
    }
}
