using System;

namespace MethodsInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetRectangleArea(10, 20);
            //PrintTotalAmountForBooks(new decimal[] { 10, 10, 10 });
            //PrintSign(-5);
            PrintMax(542, 642);
            Console.ReadLine();
        }

        public static double GetRectangleArea(double width, double height)
        {
            double area = width * height;
            Console.WriteLine("Area of rectangle with width = {0} and height = {1} is {2}", width, height, area);
            return area;
        }

        public static void PrintTotalAmountForBooks(decimal[] prices)
        {
            decimal totalAmount = 0;
            foreach (decimal singleBookPrice in prices)
            {
                totalAmount += singleBookPrice;
            }
            Console.WriteLine("The total amout for all books is: " + totalAmount);
        }

        static void PrintSign(int number)
        {
            if (number > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        static void PrintMax(float number1, float number2)
        {
            float max = number1;

            if (number2 > max)
            {
                max = number2;
            }
            Console.WriteLine("Maximal number: " + max);
        }
    }
}
