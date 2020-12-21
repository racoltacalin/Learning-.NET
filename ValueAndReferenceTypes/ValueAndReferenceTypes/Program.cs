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

            /*
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
            */

            /*
            // An ordinary character
            char character = 'a';
            Console.WriteLine(character);

            // Unicode character code in a hexadecimal format
            character = '\u003A';
            Console.WriteLine(character);

            // Assigning the single quotiation character (escaped as \')
            character = '\'';
            Console.WriteLine(character);

            // Assigning the backslash character (escaped as \\)
            character = '\\';
            Console.WriteLine(character);
            */

            /*
            string quotation = "\"Hello, Jude\", he said.";
            Console.WriteLine(quotation);

            string path = "C:\\Windows\\Notepad.exe";
            Console.WriteLine(path); 
            
            string verbatim = @"The \ is not escaped as \\.
            I am at a new line."; 
            Console.WriteLine(verbatim);
            */

            /*
            // 1. Declare several variables by selecting for each one of them the most
            // appropriate of the types sbyte, byte, short, ushort, int, uint,
            // long and ulong in order to assign them the following values:
            // 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112;
            // -44; -1,000,000; 1990; 123456789123456789.

            sbyte a = 112;
            sbyte b = -44;
            sbyte c = -115;
            sbyte d = 97;
            byte e = 224;
            short f = 1990;
            ushort g = 20000;
            short h = -10000;
            int l = 52130;
            int m = 4825932;
            int n = 970700000;
            int o = -1000000;
            double p = 123456789123456789; //long
            */

            /*
            // 2.Declare two variables of type int.
            //Assign to them values 5 and 10 respectively.
            //Exchange (swap) their values and print them.
            // Version 1:
            int a = 5;
            int b = 10;
            int oldA = a;
            a = b;
            b = oldA;
            Console.WriteLine("a = {0} | b = {1}", a, b);
            */

            /*
            // 2.Declare two variables of type int.
            //Assign to them values 5 and 10 respectively.
            //Exchange (swap) their values and print them.
            // Version 2:
            int a = 5;
            int b = 10;

            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = {0} | b = {1}", a, b);
            */

            /*
            //2.Declare two variables of type int.
            //Assign to them values 5 and 10 respectively.
            //Exchange (swap) their values and print them.
            // Version 3:
            int x, y;
            Console.WriteLine("Enter two numbers: \n");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            // printing the numbers before swapping 
            Console.WriteLine("Numbers before swapping");
            Console.WriteLine("x = {0} | y = {1}", x, y);

            // Swapping 
            x = x ^ y;
            y = x ^ y;
            x = x ^ y;

            // Printing the numbers after swapping
            Console.WriteLine("Numbers after swapping");
            Console.WriteLine("x = {0} | y = {1}", x, y);

            Console.ReadLine();
            */


        }
    }
}
