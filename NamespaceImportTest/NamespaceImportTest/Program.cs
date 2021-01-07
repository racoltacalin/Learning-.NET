using System;

namespace NamespaceImportTest
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.List<int> ints = new System.Collections.Generic.List<int>();
            var doubles = new System.Collections.Generic.List<double>();

            while (true)
            {
                int intResult;
                double doubleResult;
                Console.Write("Enteer an int or a double: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out intResult))
                {
                    ints.Add(intResult);
                }
                else if (double.TryParse(input, out doubleResult))
                {
                    doubles.Add(doubleResult);
                }
                else
                {
                    break;
                }
            }

            Console.Write("You entered {0} ints:", ints.Count);
            foreach (var i in ints)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            Console.Write("You entered {0} doubles:", doubles.Count);
            foreach (var d in doubles)
            {
                Console.Write(" " + d);
            }
            Console.WriteLine();
        }
    }
}
