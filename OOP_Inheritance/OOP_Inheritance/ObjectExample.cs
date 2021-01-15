using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public class ObjectExample
    {
        static void Main()
        {
            AfricanLion africanLion = new AfricanLion(true, 90);
            // Implicit Casting
            object obj = africanLion;

            try
            {
                // Explicit Casting
                AfricanLion castedLion = (AfricanLion)obj;
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine("obj cannot be downcasted to AfricanLion");
            }

            Console.WriteLine(new object());
            Console.WriteLine(new Felidae(true));
            Console.WriteLine(new Lion(true, 80));
            Console.WriteLine();


            // Override Example
            string asAfricanLion = africanLion.ToString();
            string asObject = ((object)africanLion).ToString();
            Console.WriteLine(asAfricanLion);
            Console.WriteLine(asObject);


            // Transitivity Example
            AfricanLion africanLionE = new AfricanLion(true, 16);
            // Property defined in Felidae
            bool male = africanLion.Male;
            africanLion.Male = true;

            // Abstraction Example

            Lion lion = new Lion(true, 150);
            Felidae bigCat1 = lion;

            AfricanLion africanLionBig = new AfricanLion(true, 250);
            Felidae bigCat2 = africanLionBig;
        }
    }
}
