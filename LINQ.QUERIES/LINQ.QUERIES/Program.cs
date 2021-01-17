using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.QUERIES
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers =
                from num in numbers
                where num % 2 == 0
                select num;
            foreach (var item in evenNumbers)
            {
                Console.Write(item + " ");

            }

            Console.WriteLine();
            Console.WriteLine();

            string[] words = { "cherry", "apple", "blueberry", "bananas" };
            var wordsSortedByLength =
                from word in words
                orderby word.Length descending
                select word;
            foreach (var word in wordsSortedByLength)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();
            Console.WriteLine();


            int[] numbersLast = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0, 10, 11, 12, 13 };
            int divisor = 5;

            var numberGroups =
                from number in numbersLast
                group number by number % divisor into groupNumber
                select new { Remainder = groupNumber.Key, Numbers = groupNumber };

            foreach (var group in numberGroups)
            {
                Console.WriteLine("Numbers with a remainder of {0} when divided by {1}:", groupNumber.Remainder, divisor);
                foreach (var number in groupNumber.Numbers)
                {
                    Console.WriteLine(number);
                }
            }

        }
        */
    }
}
