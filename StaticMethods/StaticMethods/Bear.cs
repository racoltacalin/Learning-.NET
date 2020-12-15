using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    public class Bear
    {
        // Static (class) variable
        public static int bearCount = 0;

        // Instance variables
        private string name;
        private int age;

        public Bear(string _name, int _age)
        {
            this.name = _name;
            this.age = _age;

            // Modifying the static counter in the constructor
            Bear.bearCount += 1;
        }
    }
}
