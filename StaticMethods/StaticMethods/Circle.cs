using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    public class Circle
    {
        public static double PI = 3.141592653589793;

        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public static double CalculateSurface(double radius)
        {
            return(PI * radius * radius);
        }

        public void PrintSturface()
        {
            double surface = CalculateSurface(radius);
            Console.WriteLine("Circle's surface is: " + surface);
        }
    }
}
