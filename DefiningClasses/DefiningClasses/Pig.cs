using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pig
    {
        /*
        private string name;
        private int age;
        private double length;
        private Collar collar;
        */

        public string name;
        public int age;
        public double length;
        public Collar collar;

        public Pig()
        {
            this.name = "Sharo";
            this.age = 3;
            this.length = 0.5;
            this.collar = new Collar();
        }

        public Pig(string pigName, int pigAge, double pigLength)
        {
            name = pigName;
            age = pigAge;
            length = pigLength;
            collar = new Collar();
        }

        /*
        public Pig(string name, int age, double length)
        {
            name = name;
            age = age;
            length = length;
            collar = new Collar();
        }
        */
    }
}
