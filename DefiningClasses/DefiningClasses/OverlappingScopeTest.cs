using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class OverlappingScopeTest
    {
        int myValue = 3;

        public void PrintMyValue()
        {
            int myValue = 5;
            Console.WriteLine("My value is: " + this.myValue);
        }

        public int CalculateNewValue(int newValue)
        {
            int result = myValue + newValue;
            return result;
        }
    }
}
