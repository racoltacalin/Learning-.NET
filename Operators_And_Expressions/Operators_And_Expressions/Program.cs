using System;

namespace Operators_And_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Check_Odd();
            //Check_Divisible();
            //Check_ThirdDigit();
            //Calculate_TheSumOfDigits();
            Print_TheNumberInReversedOrder();
            Console.ReadLine();
        }

        public static void Check_Odd()
        {
            int a;
            string userInput;
            Console.Write("Insert the number you want to check if it is even or odd: ");
            userInput = Console.ReadLine();
            a = Convert.ToInt32(userInput);
            if (a % 2 == 0)
            {
                Console.WriteLine($"The number {a} is even!");
            }
            else
            {
                Console.WriteLine($"The number {a} is odd!");
            }
        }

        public static void Check_Divisible()
        {
            int a;
            string userInput;
            Console.Write("Insert the number you want to check if it is divisible by both 5 and 7: ");
            userInput = Console.ReadLine();
            a = Convert.ToInt32(userInput);
            Console.WriteLine((a % 5 == 0) && (a % 7 == 0) ? "The number you've insert is divisible by both 5 and 7" : "The number you've insert is NOT divisible by both 5 and 7");

        }

        public static void Check_ThirdDigit()
        {
            int a;
            int b;
            string userInput;
            Console.Write("Insert the number to looks if its third digit(right to left) is 7: ");
            userInput = Console.ReadLine();
            a = Convert.ToInt32(userInput);
            b = a / 100;
            if ( b % 10  == 7)
            {
                Console.WriteLine("The third digit right to left is 7!");
            }
            else
            {
                Console.WriteLine("The third digit right to left is NOT 7!");
            }
        }

        public static void Calculate_TheSumOfDigits()
        {
            int num;
            Console.Write("Please insert a four-digit number: ");
            num = Convert.ToInt32(Console.ReadLine());
            int a = num % 10;
            Console.WriteLine("The 4th digit is: {0}", a);
            int b = (num / 10) % 10;
            Console.WriteLine("The 3rd digit is: {0}", b);
            int c = (num / 100) % 10;
            Console.WriteLine("The 2nd digit is: {0}", c);
            int d = (num / 1000) % 10;
            Console.WriteLine("The 1st digit is: {0}", d);
            int sum = a + b + c + d;
            Console.WriteLine("The sum of the digits is: {0}", sum);
        }

        public static void Print_TheNumberInReversedOrder()
        {
            int num;
            Console.Write("Please insert a four-digit number: ");
            num = Int32.Parse(Console.ReadLine());
            int reversedNumber = 0;
            while(num > 0)
            {
                int remainder = num % 10;
                reversedNumber = (reversedNumber * 10) + remainder;
                num = num / 10;
            }
            Console.WriteLine("The reversed number is {0}", reversedNumber);
        }
    }
}
