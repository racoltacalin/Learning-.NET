using System;
using System.Numerics;

namespace ConsoleInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Check_NumberIsPrime();
            //Calculating_Factorial();
            //Calculate_Factorial_Using_DoWhile();
            //Find_Product_InRange();
            //Sum_Of_Odds();
            //Check_ForEach();
            Draw_Triangle();
            Console.ReadLine();
        }

        public static void Check_NumberIsPrime()
        {
            Console.Write("Enter a positive number: ");
            int num = int.Parse(Console.ReadLine());
            int divider = 2;
            int maxDivider = (int)Math.Sqrt(num);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (num % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Prime? " + prime);
        }

        public static void Calculating_Factorial()
        {
            Console.Write("Please insert the number for calculate the factorial of it: ");
            int n = int.Parse(Console.ReadLine());
            decimal factorial = 1;
            Console.Write($"{n}! = ");
            while(true)
            {
                if ( n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
            }
            Console.Write(factorial);
        }

        // Calculate the factorial of a given number n, but this time
        // instead of an infinite while loop we will use a do-while.
        public static void Calculate_Factorial_Using_DoWhile()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"{n}! = ");
            //decimal factorial = 1;
            BigInteger factorial = 1;
            do
            {
                factorial *= n;
                n--;
            }
            while (n > 0);
            Console.WriteLine(factorial);
        }

        // The goal is to find the product of all numbers in the range [n…m].
        public static void Find_Product_InRange()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            int num = n;
            long product = 1;
            do
            {
                product *= num;
                num++;
            }
            while (num <= n);

            Console.WriteLine("product[n...m] = " + product);
        }

        // Calculate the sum of all odd integers in the range [1…n],
        // which are not divisible by 7 by using the for-loop
        public static void Sum_Of_Odds()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <=n; i += 2)
            {
                if (i % 7 == 0)
                {
                    continue;
                }
                sum += i;
            }
            Console.WriteLine("sum = " + sum);
        }

        public static void Check_ForEach()
        {
            int[] numbers = { 2, 3, 5, 7, 11, 13, 17, 18 };
            foreach (int i in numbers)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            string[] towns = { "London", "Paris", "Milan", "New York" };
            foreach (string town in towns)
            {
                Console.Write(" " + town);
            }
        }

        public static void Draw_Triangle()
        {
            Console.Write("Please insert the length of n:");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();    
            }
        }
    }
}
