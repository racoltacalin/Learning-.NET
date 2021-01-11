using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsInCsharp
{
    public class Cat
    {
        // Static variable
        static int catCount;

        // Instance variable
        private string name;
        private int age;

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;

            catCount += 1;
        }

        public void Meow()
        {
            Console.WriteLine("Meow - meow");
        }

        // Non-static (instance) method
        public void PrintInfo()
        {
            // Accesing instance variables - name and age
            Console.Write("Cat's name: " + this.name + "; age: " + this.age + "; often says: ");

            // Calling instance method
            this.Meow();
        }
    }
}
