using System;

namespace ProblemsForInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            long result = Fibonacci(n);
            Console.WriteLine("Fib({0}) = {1}", n, result);
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
    }
}
