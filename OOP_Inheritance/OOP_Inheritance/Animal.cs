using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public abstract class Animal
    {
        protected void Hide()
        {
            //...
        }

        protected void Run()
        {
            //...
        }

        public abstract bool CatchPrey(object prey);
    }
}
