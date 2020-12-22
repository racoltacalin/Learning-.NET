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

            /*
            // 3. A company dealing with marketing wants to keep a data record
            // of its employees. Each record should have the following characteristic
            // – first name, last name, age, gender (‘m’ or ‘f’) and
            // unique employee number (27560000 to 27569999).
            // Declare appropriate variables needed to maintain the information
            // for an employee by using the appropriate data types and attribute names.

            string firstName = "Calin";
            string lastName = "Racolta";
            int age = 30;
            char gender = 'm';
            int idNumber = 27560000;
            */

            /*
            int a = 5;
            int b = 4;
            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a + (b++) = {0}", a + (b++));
            Console.WriteLine("a + b = {0}", a + b); 
            Console.WriteLine("a + (++b) = {0}", a + (++b));
            Console.WriteLine("a + b = {0}", a + b);
            */

            /*
            byte a = 3;
            byte b = 5;

            Console.WriteLine(a | b);
            Console.WriteLine(a & b); 
            Console.WriteLine(a ^ b); 
            Console.WriteLine(~a & b); 
            Console.WriteLine(a << 1);
            Console.WriteLine(a << 2);
            Console.WriteLine(a >> 1);
            */

            /*
            // Example of implicit type conversion:

            int myInt = 5;
            Console.WriteLine("myInt = {0}", myInt);

            long myLong = myInt;
            Console.WriteLine("myLong = {0}", myLong);
            Console.WriteLine("Result = {0}", myLong + myInt);
            */

            /*
            // Example of explicit type conversion and data loss that may occur in some cases:
            double myDouble = 5.1d;
            Console.WriteLine("myDouble = {0}", myDouble);

            long myLong = (long)myDouble;
            Console.WriteLine("myLong = {0}", myLong);

            myDouble = 5e9d;
            Console.WriteLine("myDouble = {0}", myDouble);

            int myInt = (int)myDouble;
            Console.WriteLine("myInt = {0}", myInt);
            Console.WriteLine("MinValue Of int = {0}", int.MinValue);
            Console.WriteLine("Difference from myDouble to MinValueOfInt = {0}", myDouble - int.MinValue);
            */

            /*
            //Example for data loss during type conversion:
            long myLong = long.MaxValue;
            int myInt = (int)myLong;

            Console.WriteLine("myLong = {0}", myLong);
            Console.WriteLine("myInt  = {0}", myInt);

            float heightInMeters = 1.74f; // Explicit conversion
            double maxHeight = heightInMeters; // Implicit conversion
            double minHeight = (double)heightInMeters; // Explicit conversion
            float actualHeight = (float)maxHeight; // Explicit conversion

            //float maxHeightFloat = maxHeight; // Compilation Error!
            */

            /*
            //Forcing Overflow Exceptions during Casting:
            //This is done by the keyword checked which includes a check for overflow in integer types:
            double d = 5e9d;
            Console.WriteLine("d = {0}", d);

            int i = checked((int)d);
            Console.WriteLine("i = {0}", i);
            */

            /*
            //examples for converting different data types to string: 
            int a = 5;
            int b = 7;

            string sum = "Sum = " + (a + b);
            Console.WriteLine("sum = {0}", sum);

            String incorrect = "Sum = " + a + b;
            Console.WriteLine("incorrect = {0}", incorrect);

            Console.WriteLine("Perimeter = " + 2 * (a + b) + ". Area = " + (a * b) + ".");
            */

            /* 
            // Side Effects of Expressions
            int a = 5;
            int b = ++a;

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            */




        }
    }
}
