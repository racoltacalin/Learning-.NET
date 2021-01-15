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

            // Abstract Class
            Console.WriteLine();
            AnimalOfAnimal cat = new Cat();
            cat.PrintInformation();

            // Virtual Methods
            Console.WriteLine();
            Lion lion1 = new Lion(true, 90);
            lion1.CatchPrey(null);
            // Will print "Lion.CatachPrey"

            AfricanLion lion2 = new AfricanLion(true, 120);
            lion2.CatchPrey(null);
            // Will print "AfricanLion.CatchPrey"


            Lion lion3 = new AfricanLion(false, 60);
            lion3.CatchPrey(null);
            // Will print "AfricanLion.CatchPrey", because
            // the variable lion has a value of type AfricanLion
        }
    }
}
