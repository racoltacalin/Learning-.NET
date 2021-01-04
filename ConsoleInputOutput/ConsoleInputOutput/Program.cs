using System;

namespace ConsoleInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Check_NumberIsPrime();
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
    }
}
