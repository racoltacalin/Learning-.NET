using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public class AfricanLion : Lion
    {
        // ...

        // If we comment out the ": base(male, weight)" line
        // the class will not compile. Try it!
        public AfricanLion(bool male, int weight) : base(male, weight)
        {

        }

        public override string ToString()
        {
            return string.Format("(AfricanLion, male: {0}, weight: {1})", this.Male, this.Weight);
        }
    }
}
