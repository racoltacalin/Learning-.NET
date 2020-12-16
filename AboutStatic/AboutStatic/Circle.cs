using System;
using System.Collections.Generic;
using System.Text;

namespace AboutStatic
{
    public class Circle
    {
        // Instance field = non-static fields
        //float PI = 3.141F;
        public static float PI = 3.141F;
        int Radius;

        static Circle()
        {
            Console.WriteLine("Static Constructor Called");
            Circle.PI = 3.141F;
        }


        public Circle(int radius)
        {
            Console.WriteLine("Instance Constructor Called");
            this.Radius = radius;
        }



        public float CalculateArea()
        {
            return Circle.PI * this.Radius * this.Radius; 
        }
    }
}
