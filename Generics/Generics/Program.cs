using System;
using System.Collections.Generic;
using System.Collections;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add(23);
            list.Add("Hello");

            List<int> ages = new List<int>();

            ages.Add(23);

            Console.WriteLine();
            Console.WriteLine("Press enter to shut down...");
            Console.ReadLine();
        }

        private static void DemonstrateTextFileStorage()
        { 
        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        { 
        }
    }
}
