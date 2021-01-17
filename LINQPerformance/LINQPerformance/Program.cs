using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            PerfomLINQ();
        }

        static void PerfomLINQ()
        {
            HashSet<Guid> set = new HashSet<Guid>();
            for (int i = 0; i < 50000; i++)
            {
                set.Add(Guid.NewGuid()); // Add random GUID
            }

            Guid keyForSearching = new Guid();
            DateTime start = DateTime.Now;
            for (int i = 0; i < 50000; i++)
            {
                // Use HashSet.Contains(...)
                bool found = set.Contains(keyForSearching);
            }
            Console.WriteLine("HashSet: {0}", DateTime.Now - start);

            start = DateTime.Now;
            for (int i = 0; i < 50000; i++)
            {
                // Use IEnumerable<Guid>.Contains(...) extension method
                bool found = set.Contains<Guid>(keyForSearching);
            }
            Console.WriteLine("Contains: {0}", DateTime.Now - start);

            start = DateTime.Now;
            for (int i = 0; i < 50000; i++)
            {
                // Use IEnumerable<Guid>.Where(...) extension method
                bool found = set.Where(g => g == keyForSearching).Count() > 0;
            }
            Console.WriteLine("Where: {0}", DateTime.Now - start);
        }
    }
}
