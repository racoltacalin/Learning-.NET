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

        public static int dogCount;

        public int Age
        {
            get { return this.age; }
            set 
            {
                // Take precaution: perform check for correctness
                if (value < 0)
                {
                    throw new ArgumentException("Invalid argument: Age should be a positive number.");
                }

                // Assign the new correct value
                this.age = value;
            }
        }

        /*
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
        */

        // No parameters
        public Dog()
        : this("Axl") // Constructor call
        {
            // More code could be added here
        }

        // One parameter
        public Dog(string name)
        : this(name, 1) // Constructor call
        {
            // More code could be added here
        }

        // Two parameters
        public Dog(string name, int age)
        : this(name, age, 0.3) // Constructor call
        {
            // More code could be added here
        }

        // Three parameters
        public Dog(string name, int age, double length)
        : this(name, age, length, new Collar()) // Constructor call
        {
            // More code could be added here
        }

        // Four parameters
        public Dog(string name, int age, double length, Collar collar)
        {
            this.name = name;
            this.age = age;
            this.length = length;
            this.collar = collar;

            // Modifying the static counter in the constructor
            Dog.dogCount += 1;
            //dogCount += 1;
        }
    }
}
