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
            Find_Product_InRange();
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
    }
}
