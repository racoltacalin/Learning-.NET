using System;
using System.ComponentModel;

namespace EstimateComplexity
{
    class Program
    {
        static void Main(string[] args)
        {

            //FibonacciN(100);
            //Fibonacci(100);
            //Factorial(100);
            //SumMN(1000, 1100);
            //FindMaxElement(1, 2, 3, 4, 5);
            //FindInversions(1, 2, 3, 4, 5, 6);
            //Sum3(1000);
        }



        // If we have a single loop from 1 to N, its complexity is linear – O(N):
        // This code will work well even if the number of elements is huge.
        public static int FindMaxElement(params int[] array)
        {
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        // If we have two of nested loops from 1 to N, their complexity is quadratic – O(N^2).
        // If the elements are no more than several thousand or tens of thousands, this
        // code will work well.
        public static int FindInversions(params int[] array)
        {
            int inversions = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        inversions++;
                    }
                }
            }
            return inversions;
        }

        // If we have tree nested loops from 1 to N, their complexity is cubic – O(N^3)
        // This code will work well if the number of elements is below 1,000.
        public static long Sum3(int n)
        {
            long sum = 0;
            for (int a = 1; a < n; a++)
            {
                for (int b = 1; b < n; b++)
                {
                    for (int c = 1; c < n; c++)
                    {
                        sum += a * b * c;
                    }
                }
            }

            return sum;
        }

        // If we have two nested loops from 1 to N and from 1 to M respectively,
        // their complexity will be quadratic – O(N * M).
        // The speed of this code depends on two variables. The code will work well if
        // M, N< 10,000 or if at least the one variable has a value small enough.

        public static long SumMN(int n, int m)
        {
            long sum = 0;
            for (int x = 1; x <= n; x++)
            {
                for (int y = 0; y <= m; y++)
                {
                    sum += x * y;
                }
            }
            return sum;
        }

        // We should pay attention to the fact that not always tree nested loops mean
        // cubic complexity.Here is an example in which the complexity is O(N * M).
        // In this example the most inner loop executes exactly min(M, N) times and
        // does not significantly affect the algorithm speed.The outer code executes
        // approximately N*M + min(M, N)*N steps, i.e.its complexity is quadratic.
        public static long SumMN2(int n, int m)
        {
            long sum = 0;
            for (int x = 1; x <= n; x++)
            {
                for (int y = 1; y <= m; y++)
                {
                    if (x == y)
                    {
                        for (int i = 1; i <= n; i++)
                        {
                            sum += i * x * y;
                        }
                    }
                }
            }
            return sum;
        }

        // When using a recursion, the complexity is more difficult to be
        // estimated.Here is an example:
        // In this example the complexity is obviously linear – O(N), because the
        // function Factorial() executes exactly once for each of the numbers 1 … n.
        public static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        /// Here is a recursive function for which it is very difficult to estimate the
        /// complexity:
        /// <summary>If we write down what really happens when the upper code executes, we will
        /// see that the function calls itself as many times as the Fibonacci’s n+1 number
        /// is. We can roughly evaluate the complexity by another way too: since on
        /// every step of the function execution 2 recursive calls are done in average, the
        /// count of the recursive calls must be in order of 2n, i.e.we have an
        /// exponential complexity.This automatically means that for values greater
        /// than 20-30 the function will "hang".</summary>
        
        public static long Fibonacci(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        // The same function for calculating the n^th number of Fibonacci can be
        // written with a linear complexity in the following way:
        public static long FibonacciN(int n)
        {
            long fn = 1;
            long fn1 = 1;
            long fn2 = 1;
            for (int i = 2; i < n; i++)
            {
                fn = fn1 + fn2;
                fn2 = fn1;
                fn1 = fn;
            }
            return fn;
        }
    }
}
