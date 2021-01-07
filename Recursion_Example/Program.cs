using System;

namespace Recursion_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            CountOccurences(new int[] { 3, 2, 2, 5, 1, -8, 7, 2 });
        }

        static void CountOccurences(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int count = 0;
                if (numbers[i] == numbers[i+1])
                {
                    count += 1;
                }
                Console.WriteLine("Count = {0}", count);
            }
        }
    }
}
