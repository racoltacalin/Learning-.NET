using System;

namespace AboutStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle1 = new Circle(5);
            float area1 = circle1.CalculateArea();
            Console.WriteLine("Area of the circle is: {0}", area1);
            Console.WriteLine();

            var circle2 = new Circle(6);
            float area2 = circle2.CalculateArea();
            Console.WriteLine("Area of the circle is: {0}", area2);
            Console.WriteLine();

            Console.WriteLine(Circle.PI);
            /*
            for (int i = 0; i < 100; i++)
            {
                Circle objectA = new Circle(i);
                float areaA = objectA.CalculateArea();
                Console.WriteLine("Area of the circle[{0}] is: {1}", i, areaA);
            }
            */
            Console.ReadLine();
        }
    }
}
