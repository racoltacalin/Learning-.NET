using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep_Example
{
    public class RefAndOutExample
    {
        static void Main()
        {
            int val1 = 1;
            int val2;

            Example1(ref val1);
            Console.WriteLine(val1);

            Example2(out val2);
            Console.WriteLine(val2);
        }
        public static void Example1(ref int value1)
        {
            value1 = 1;
        }

        public static void Example2(out int value2)
        {
            value2 = 2;
        }
    }
}
