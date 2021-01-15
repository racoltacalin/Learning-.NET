using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public class Lion : Felidae
    {
        private int weight;

        // Keyword "base" 
        public Lion(bool male, int weight) : base(male)
        {
            // Compiler error - base.male is not visible in Lion
            Male = male;
            this.weight = weight;
        }

        public int Weight
        {
            get { return weight; }
            set { this.weight = value; }
        }
    }
}
