using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Memory allocation | STACK vs HEAP 
            int i = 42;
            char ch = 'A';
            bool result = true;
            object obj = 42;
            string str = "Hello";
            byte[] bytes = { 1, 2, 3 };

            i = 0;
            ch = 'B';
            result = false;
            obj = null;
            str = "Bye";
            bytes[1] = 0;
            */


            // The following variables are initialized with the same value
            int numberInDec = 16;
            int numberInHex = 0x10;
            Console.WriteLine("numberInDec: {0} \nnumberinHex: {1}", numberInDec, numberInHex);

            // This will cause an error, because the value 234L is not int
            //int longInt = 234L;

            // The following is the correct way of assigning a value:
            float realNumber = 12.5f;

            // This is the same value in exponential format:
            realNumber = 1.25e+1f;

            // The following causes an error, because 12.5 is double
            //float realNumber = 12.5;
        }
    }
}
