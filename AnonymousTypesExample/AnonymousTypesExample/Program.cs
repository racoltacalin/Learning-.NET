using System;

namespace AnonymousTypesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new { Color = "Red", Brand = "BMW", Speed = 180 };

            Console.WriteLine("My car is a {0} : {1}.", myCar.Color, myCar.Brand);
            Console.WriteLine("It runs {0} km/h", myCar.Speed);
            Console.WriteLine();

            var arr = new[]
            {
                new {X = 3, Y = 5},
                new {X = 1, Y = 2 },
                new {X = 0, Y = 8}
            };
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
