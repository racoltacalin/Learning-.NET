using System;

namespace MethodsInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetRectangleArea(10, 20);
            PrintTotalAmountForBooks(new decimal[] { 10, 10, 10 });
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
    }
}
