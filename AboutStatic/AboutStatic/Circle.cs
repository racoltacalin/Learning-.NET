using System;
using System.Collections.Generic;
using System.Text;

namespace AboutStatic
{
    public class Circle
    {
        // Instance field = non-static fields
        //float PI = 3.141F;
        static float PI = 3.141F;
        int Radius;

        public Circle(int radius)
        {
            this.Radius = radius;
        }



        public float CalculateArea()
        {
            return Circle.PI * this.Radius * this.Radius; 
        }
    }
}
