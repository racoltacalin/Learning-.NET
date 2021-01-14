using System;
using System.Collections.Generic;

namespace HashFunctionExample
{
    class Program
    {

        static void Main()
        {
            IEqualityComparer<Point3D> comparer = new Point3DEqualityComparer();
            Dictionary<Point3D, int> dict = new Dictionary<Point3D, int>(comparer);

            dict[new Point3D(4, 2, 5)] = 5;
            dict[new Point3D(1, 2, 3)] = 1;
            dict[new Point3D(3, 1, -1)] = 3;
            dict[new Point3D(1, 2, 3)] = 10;

            foreach (var entry in dict)
            {
                Console.WriteLine("{0} --> {1}", entry.Key, entry.Value);
            }

        }



        /*
        public override unsafe int GetHashCode()
        {
            fixed (char* str = ((char*)this))
            {
                char* chPtr = str;
                int num = 352654597;
                int num2 = num;
                int* numPtr = (int*)chPtr;

                for (int i = this.Length; i > 0; i -= 4)
                {
                    num = (((num << 5) + num) + (num >> 27)) ^ numPtr[0];
                    if (i <= 2)
                    {
                        break;
                    }
                    num2 = (((num2 << 5) + num2) + (num2 >> 27)) ^ numPtr[1];
                    numPtr += 2;
                }
                return (num + (num2 * 1566083941));
            }
        }
        */
    }
}
