using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public class Cat : AnimalOfAnimal
    {
        protected override string GetTypicalSound()
        {
            return "Meoooooow!";
        }
    }
}
