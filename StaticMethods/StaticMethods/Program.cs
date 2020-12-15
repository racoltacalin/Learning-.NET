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
    public class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */

            /*
            var dog = new Dog();

            Console.WriteLine("Dog's name is: " + dog.name);
            Console.WriteLine("Dog's age is: " + dog.age);
            Console.WriteLine("Dog's length is: " + dog.length);
            Console.WriteLine("Dog is male: " + dog.isMale);
            */

            /*
            Console.WriteLine(PI);
            Console.WriteLine(ConstAndReadOnlyExample.PI);
            var instance = new ConstAndReadOnlyExample(5);
            Console.WriteLine(instance.Size);

            // Compile-time error: cannot access PI like a field
            Console.WriteLine(instance.PI);
            // Compile-time error: Size is instance field (non-static)
            Console.WriteLine(ConstAndReadOnlyExample.Size);
            // Compile-time error: cannot modify a constant
            ConstAndReadOnlyExample.PI = 0;
            // Compile-time error: cannot modify a readonly field
            instance.Size = 0;
            */

            /*
            var instance = new OverlappingScopeTest();
            instance.PrintMyValue();
            */

            /*
            var myCat = new Cat();
            Console.WriteLine("My cat's name is " + myCat.Name);
            myCat.DoSomething();
            */

            /*
            var bear1 = new Bear("Jackie", 1);
            var bear2 = new Bear("Lassy", 2);
            var bear3 = new Bear("Relu", 3);

            Console.WriteLine("Bear count is now " + Bear.bearCount);
            */

            /*
            var rabbit = new Rabbit("Monty", 3);
            rabbit.PrintInfo();
            */

            /*
            var circle = new Circle(3);
            circle.PrintSturface();
            */

            /*
            double radius = 5;

            // Accessing static method from other static method
            double circlePerimeter = CalculateCirclePerimeter(radius);

            Console.WriteLine("Circle with radius " + radius + " has perimeter: " + circlePerimeter);
            */

            /*
            //Atempt to invoke non-static method from a static context
            PrintAge(); //INVALID
            this.PrintAge(); // INVALID
            */

            /*
            var myRabbit = new Rabbit("Lassie", 3);
            var myRabbitName = myRabbit.name;
            Console.WriteLine("My rabbit \"" + myRabbit.name + "\" has age of ");
            myRabbit.PrintAge();
            Console.WriteLine(" years");
            */

            /*
            var sysInfoInstance = new SystemInfo();
            //Console.WriteLine("System version: " + sysInfoInstance.Version); // INVALID

            // Invocation of static property setter
            SystemInfo.Vendor = "Microsoft Corporation";

            // Invocation of static property getters
            Console.WriteLine("System version: " + SystemInfo.Version);
            Console.WriteLine("System vendor: " + SystemInfo.Vendor);
            */


            Console.WriteLine(SqrtPrecalculated.GetSqrt(254));

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

        public static int Add(int number1, int number2)
        {
            int result = number1 + number2;
            return result;
        }
    }
}
