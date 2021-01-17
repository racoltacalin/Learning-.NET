using System;
using System.Collections.Generic;

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Extension Methods for Interfaces
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(numbers.ToString<int>());
            numbers.IncreaseWith(5);
            Console.WriteLine(numbers.ToString<int>());

            /*
            // Extension Methods - Example
            string helloString = "Hello, Extension Methods!";
            int wordCount = helloString.WordCount();
            Console.WriteLine(wordCount);
            */
        }
    }
}
