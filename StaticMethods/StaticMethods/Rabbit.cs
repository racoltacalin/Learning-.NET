using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    public class Rabbit
    {
        // Static field
        static int rabbitCount;

        // Instance variables;
        public string name;
        private int age;

        public Rabbit(string name, int age)
        {
            this.name = name;
            this.age = age;

            rabbitCount += 1;
        }

        public void SayHello()
        {
            Console.WriteLine("zmmm - zmmm");
        }

        // Non-static (instance) method
        public void PrintInfo()
        {
            // Accessing instance variables - name and age
            Console.Write("Rabbit's name is: " + this.name + "; age: " + this.age + "; often says: ");

            // Calling instance method
            this.SayHello();
        }

        public static void PrintName()
        {
            // Trying to access non-static variable from static method
            //Console.WriteLine(name); // INVALID
            //Console.WriteLine(this.name); // INVALID
        }

        public void PrintAge()
        {
            Console.WriteLine(this.age);
        }
    }
}
