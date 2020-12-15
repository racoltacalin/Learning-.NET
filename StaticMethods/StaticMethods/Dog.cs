using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    public class Dog
    {
        public string name = null;
        public int age = 0;
        public double length = 0;
        public bool isMale = false;
        public Collar collar;

        public Dog()
        {
            this.name = "Shaggy";
            this.age = 3;
            this.length = 0.5;
            this.collar = new Collar();
        }
        public int GetAge()
        {
            return this.age;
        }
        public void MakeOlder()
        {
            this.age++;
        }
    }
}
