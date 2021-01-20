using System;
using System.Collections.Generic;
using System.Net;

namespace ProblemsForInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            long resultFibonacci = Fibonacci(n);
            Console.WriteLine("Fib({0}) = {1}", n, resultFibonacci);
            Console.WriteLine();

            var integerList = GetIntegers();
            FizzBuzz(integerList);

        }

        static long Fibonacci(int n)
        {
            long fn = 0;
            long fnMinus1 = 1;
            long fnMinus2 = 1;

            for (int i = 2; i < n; i++)
            {
                fn = fnMinus1 + fnMinus2;
                fnMinus2 = fnMinus1;
                fnMinus1 = fn;
            }
            return fn;
        }

        public static List<int> GetIntegers()
        {
            var integerList = new List<int>();

            for (int i = 0; i <= 100; i++)
            {
                integerList.Add(i);
            }

            return integerList;
        }

        public static void FizzBuzz(List<int> integerList)
        {
            foreach (var item in integerList)
            {
                if (item % 3 == 0 && item % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (item % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (item % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
