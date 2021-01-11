using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorsInCsharp
{
    public class Dog
    {
        public string name;
        public int age;
        public double length;
        public Collar collar;

        public Dog()
        {
            this.name = "Axl";
            this.age = 1;
            this.length = 0.3;
            this.collar = new Collar();
        }

        // One parameter
        public Dog(string name)
        {
            this.name = name;
            this.age = 1;
            this.length = 0.3;
            this.collar = new Collar();
        }

        // Two parameters
        public Dog(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.length = 0.3;
            this.collar = new Collar();
        }

        // Three parameters
        public Dog(string name, int age, double length)
        {
            this.name = name;
            this.age = age;
            this.length = length;
            this.collar = new Collar();
        }

        // Four parameters
        public Dog(string name, int age, double length, Collar collar)
        {
            this.name = name;
            this.age = age;
            this.length = length;
            this.collar = collar;
        }
    }
}
