using System;
/*
 * In C#: 
 * 1. subroutines => methods 
 * 2. A method cannot be declared inside another method's BODY! 
 * 3. In the C# language, a method can be declared only between the opening "{" and the closing "}" brackets of a class.
 * 4. Access modifiers => public | static
 * 5. A modifier is a keyword in C#, which gives additional information to the compiler for a certain code.
 * 6.
 * 7.
 * 8.
 * 9.
 * 10.
 */

namespace StaticMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrArg = new int[] { 1, 2, 3, 4 };

            Console.Write("Before ModifyArray() the argument is: ");
            PrintArray(arrArg);
            Console.WriteLine();

            //Modifying the array's argument
            ModifyArray(arrArg);
            Console.WriteLine();

            Console.Write("After ModifyArray() the param is: ");
            PrintArray(arrArg);
            Console.WriteLine();

            Console.ReadLine();
        }
        
        static double GetRectangleArea(double width, double height)
        {
            double area = width * height;
            return area;
        }

        public static void PrinLogo()
        {
            Console.WriteLine("Microsoft");
            Console.WriteLine("www.microsoft.com");
        }

        public static void ModifyArray(int[] arrParam)
        {
            arrParam[0] = 5;
            Console.Write("In ModifyArray() the param is: ");
            PrintArray(arrParam);
        }

        public static void PrintArray(int[] arrParam)
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
            Console.Write("]");
        }
    }
}
