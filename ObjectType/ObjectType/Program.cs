using System;

namespace ObjectType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare some variables
            object container1 = 5;
            object container2 = "Five";

            // Print the results on the console
            Console.WriteLine("The value of container1 is: " + container1);
            Console.WriteLine("The value of container2 is: " + container2);
            Console.WriteLine();

            // Nullable Types
            /* 
            Nullable<int> i1 = null;
            int? i2 = i1;
            */

            /*
            int i = 5;
            int? ni = i;
            Console.WriteLine($"The value of ni = { ni }"); // 5

            // i = ni; // this will fail to compile
            Console.WriteLine($"Variable ni is: { ni.HasValue }"); // True
            i = ni.Value;
            Console.WriteLine(i); // 5

            ni = null;
            Console.WriteLine($"Variable ni is: { ni.HasValue }" ); // False
            // i = ni.Value; // System.InvalidOperationException
            i = ni.GetValueOrDefault();
            Console.WriteLine($"The value of i = { i }"); // 0 
            */

            
            Console.ReadLine();
        }
    }
}
