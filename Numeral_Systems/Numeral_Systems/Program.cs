using System;

namespace Numeral_Systems
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum_TheNumber();
            //Bitwise_And_ToCheck_EvenOrOdd();
            //Bitwise_OR_ToRaise_ByOne();
            How_To_CreateErrors();
            Console.ReadLine();
        }

        public static void Sum_TheNumber()
        {
            int a = 2;
            Console.WriteLine(Math.Pow(a, 15));
        }

        public static void Bitwise_And_ToCheck_EvenOrOdd()
        {
            int integer1 = 10111011;
            int integer2 = 00000001;
            int result = integer1 & integer2;
            if (result == 1)
            {
                Console.WriteLine("The integer1 is ODD!");
            }
            else
            {
                Console.WriteLine("The integer 1 is EVEN!");
            }
        }

        public static void Bitwise_OR_ToRaise_ByOne()
        {
            int integer1 = 10111011;
            int integer2 = 0000000;
            int result = integer1 | integer2;
            Console.WriteLine("Result is: {0}", result);
        }

        public static void How_To_CreateErrors()
        {
            float sum = 0f;
            for (int i = 0; i < 1000; i++)
            {
                sum += 0.1f;
            }
            Console.WriteLine("Sum = {0}", sum);
        }
    }
}
