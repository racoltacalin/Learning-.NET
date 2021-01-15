using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public class Tiger : Animal
    {
        protected void Ambush()
        {
            //...
        }

        public override bool CatchPrey(object prey)
        {
            base.Hide();
            this.Ambush();
            base.Run();
            //...
            return false;
        }
    }
}
