using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    public class OverlappingScopeTest
    {
        int myValue = 3;

        public void PrintMyValue()
        {
            Console.WriteLine("My value is: " + myValue);
        }
    }
}
