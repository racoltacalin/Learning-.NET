using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    class Color
    {
        //public const Color Black = new Color(0, 0, 0);
        //public const Color White = new Color(255, 255, 255);
        
        public static readonly Color Black = new Color(0, 0, 0);
        public static readonly Color White = new Color(255, 255, 255);

        private int red;
        private int green;
        private int blue;

        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }
    }
}
