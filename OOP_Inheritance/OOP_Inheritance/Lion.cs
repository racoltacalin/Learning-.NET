using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public class Lion : Felidae, Reproducible<Lion>
    {
        private int weight;

        private Paw frontLeft;
        private Paw frontRight;
        private Paw bottomLeft;
        private Paw bottomRight;

        private void MovePow(Paw paw)
        {
            // ...
        }

        public override void Walk()
        {
            this.MovePow(frontLeft);
            this.MovePow(frontRight);
            this.MovePow(bottomLeft);
            this.MovePow(bottomRight);
        }

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

        Lion[] Reproducible<Lion>.Reproduce(Lion mate)
        {
            return new Lion[] { new Lion(true, 12), new Lion(false, 10) };
        }

        public override void CatchPrey(object prey)
        {
            Console.WriteLine("Lion.CatchPrey");
        }
    }
}
