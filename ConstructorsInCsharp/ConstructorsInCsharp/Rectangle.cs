using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsInCsharp
{
    class Rectangle
    {
        private float height;
        private float width;

        public Rectangle(float height, float width)
        {
            this.height = height;
            this.width = width;
        }

        // Obbtaining the value of the property Area

        public float Area
        {
            get { return this.height * this.width; }
        }
    }
}
