using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    class ConstAndReadOnlyExample
    {
        public const double PI = 3.1415926535897932385;
        public readonly double Size;

        public ConstAndReadOnlyExample(int size)
        {
            this.Size = size; // Cannot be further modified!
        }
    }
}
