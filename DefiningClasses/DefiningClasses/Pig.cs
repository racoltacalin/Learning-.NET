using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pig
    {
        private string name;
        private int age;
        private double length;
        private Collar collar;

        public Pig()
        {
            this.name = "Sharo";
            this.age = 3;
            this.length = 0.5;
            this.collar = new Collar();
        }
    }
}
