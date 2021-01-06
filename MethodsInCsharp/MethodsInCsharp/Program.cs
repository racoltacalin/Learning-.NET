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

            /*
            long sum1 = CalcSum(2, 5);
            Console.WriteLine("Sum1 is : " + sum1);

            long sum2 = CalcSum(4, 0, -2, 12);
            Console.WriteLine("Sum2 is : " + sum2);

            long sum3 = CalcSum();
            Console.WriteLine("Sum3 is : " + sum3);
            */

            //PrintTotalAmountForBooksUsingParams(3m, 2.5m);
            //PrintTotalAmountForBooksUsingParams(1m, 2m, 3.5m, 7.5m);

            //PrintNumbers(2.71f, 2);
            //PrintNumbers(5, 3.14159f);
            //PrintNumbers((float)2, (short)3);

            //PrintTriangle();
            //PrintTriangle();

            /*
            bool start = true;
            int  end = 100;
            while (start) 
            {
                int n = GetTheLenghtOfTriangle();
                PrintTriangleOnMyOwn(n);
                if (n == end)
                {
                    start = false;
                }
            }
            */


            Console.ReadLine();
        }

        public static double GetRectangleArea(double width, double height)
        {
            double area = width * height;
            Console.WriteLine("Area of rectangle with width = {0} and height = {1} is {2}", width, height, area);
            return area;
        }

        public static void PrintTotalAmountForBooks(decimal v, decimal[] prices)
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

        static long CalcSum(params int[] elements)
        {
            long sum = 0;
            foreach (int element in elements)
            {
                sum += element;
            }
            return sum;
        }

        static void PrintTotalAmountForBooksUsingParams(params decimal[] prices)
        {
            decimal totalAmount = 0;

            foreach (decimal singleBookPrice in prices)
            {
                totalAmount += singleBookPrice;
            }

            Console.WriteLine("The total amount of all books is: " + totalAmount);
        }

        // Method Overloading || Draw() is called overloaded!
        static void Draw(string str)
        {
            // Draw string
        }
        static void Draw(int number)
        {
            // Draw integer
        }
        static void Draw(float number)
        {
            // Draw float number
        }

        // Overloaded Methods Invocation
        static void PrintNumbers(int intValue, float floatValue)
        {
            Console.WriteLine(intValue + "; " + floatValue);
        }
        static void PrintNumbers(float floatValue, int intValue)
        {
            Console.WriteLine(floatValue + "; " + intValue);
        }

        // Triangles with Different Size
        static void PrintTriangle()
        {
            // Entering the value of the variable n
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            // Printing the upper part of the triangle
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }

            // Printing the bottom part of the triangle
            // that is under the longest line
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static int GetTheLenghtOfTriangle()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return n;
        }

        static void PrintTriangleOnMyOwn(int n)
        {           
            // Printing the upper part of the triangle
            for (int line = 1; line <= n; line++)
            {
                PrintLine(1, line);
            }

            // Printing the bottom part of the triangle
            // that is under the longest line
            for (int line = n - 1; line >= 1; line--)
            {
                PrintLine(1, line);
            }
        }
    }
}
