using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public abstract class AnimalOfAnimal
    {
        public void PrintInformation()
        {
            Console.WriteLine("I am a {0}.", this.GetType().Name);
            Console.WriteLine(GetTypicalSound());
        }

        protected abstract String GetTypicalSound();
    }
}
