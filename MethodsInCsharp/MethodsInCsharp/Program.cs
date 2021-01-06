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
            //PrintMax(542, 642);

            /*int numberArg = 3;
            PrintNumber(numberArg);
            Console.WriteLine("In the Main() method numberArg is: " + numberArg);
            */

            /*
            int[] arrArg = new int[] { 1, 2, 3, 4, 5 };

            Console.Write("Before ModifyArray() the argument is: ");
            PrintArray(arrArg);
            // Modifying the array's argument
            ModifyArray(arrArg);

            Console.Write("After ModifyArray() the argument is: ");
            PrintArray(arrArg);
            */

            
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

        static void PrintNumber(int numberParam)
        {
            numberParam = 5;
            Console.WriteLine("In PrintNumber() method, after " + "modification, numberParam is: {0}", numberParam);
        }

        static void ModifyArray(int[] arrParam)
        {
            arrParam[0] = 5;
            Console.Write("In ModifyArray() the param is: ");
            PrintArray(arrParam);
        }

        static void PrintArray(int[] arrParam)
        {
            Console.Write("[");
            int length = arrParam.Length;

            if (length > 0)
            {
                Console.Write(arrParam[0].ToString());
                for (int i = 1; i < length; i++)
                {
                    Console.Write(", {0}", arrParam[i]);
                }
            }
            Console.WriteLine("]");
        }
    }
}
