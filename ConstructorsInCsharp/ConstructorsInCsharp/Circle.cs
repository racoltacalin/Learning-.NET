using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsInCsharp
{
    class Circle
    {
        public static double PI = 3.141592653589793;

        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public static double CalculateSurface(double radius)
        {
            return (PI * radius * radius);
        }

        public void PrintSurface()
        {
            double surface = CalculateSurface(radius);
            Console.WriteLine("Circle's surface is: " + surface);
        }

        /*
        public double X { get; set; }
        public double Y { get; set; }
        
        public Circle (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        */
    }
}
