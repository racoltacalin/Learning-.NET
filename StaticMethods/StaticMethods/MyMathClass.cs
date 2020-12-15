using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    public class MyMathClass
    {
        public const double PI = 3.141592653589793;

        // The method applies the formula: P = 2 * PI * r
        public static double CalculateCirclePerimeter(double r)
        {
            // Accessing the static variable PI from static method
            return (2 * PI * r);
        }
    }
}
