using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace GenericsExample_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic list
            List<int> listGeneric = new List<int> { 5, 9, 1, 4 };
            // non-generic list
            ArrayList listNonGeneric = new ArrayList { 5, 9, 1, 4 };
            
            // timer for generic list sort
            Stopwatch s = Stopwatch.StartNew();
            listGeneric.Sort();
            s.Stop();
            Console.WriteLine($"Generic Sort: { listGeneric } \n Time taken: { s.Elapsed.TotalMilliseconds } ms");
            Console.WriteLine();

            // time for non-generic list sort
            Stopwatch s2 = Stopwatch.StartNew(); ;
            listNonGeneric.Sort();
            s2.Stop();
            Console.WriteLine($"Non-Generic Sort: { listNonGeneric } \n Time taken: { s2.Elapsed.TotalMilliseconds } ms");

            Console.ReadLine();
        }
    }
}
