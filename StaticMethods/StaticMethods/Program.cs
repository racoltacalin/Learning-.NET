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


    }
}
