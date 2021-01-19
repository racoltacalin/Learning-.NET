using System;

namespace StructExample
{
    class Program
    {
        struct Point
        {
            public int x, y;
        }

        struct Color
        {
            public byte red;
            public byte green;
            public byte blue;
        }

        struct Square
        {
            public Point location;
            public int size;
            public Color borderColor;
            public Color sufaceColor;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
