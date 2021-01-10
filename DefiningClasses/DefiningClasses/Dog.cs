using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    // Class declaration
    public class Dog
    {
        // Field declaration
        private string name;

        // Constructor declaration (parameterless empty constructor)
        public Dog()
        {

        }

        // Another constructor declaration with parameters
        public Dog(string name)
        {
            this.name = name;
        }

        // Property declaration
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // Method declaration (non-static)
        public void Bark()
        {
            Console.WriteLine("{0} said: Wow-Wow!", name ?? "[unnamed dog]");
        }
    }
}
