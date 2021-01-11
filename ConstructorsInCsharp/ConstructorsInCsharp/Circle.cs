using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsInCsharp
{
    class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Circle (int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
