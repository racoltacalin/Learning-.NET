using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsInCsharp
{
    public class PlayWithPoints
    {
        static void PrintPoint(Point2D p)
        {
            Console.WriteLine("({0}, {1})", p.X, p.Y);
        }

        static void TryToChangePoint(Point2D p)
        {
            p.X++;
            p.Y++;
        }
        /*
        static void Main(string[] args)
        {
            Point2D point = new Point2D(3, -2);
            PrintPoint(point);
            TryToChangePoint(point);
            PrintPoint(point);
        }
        */
    }
}
