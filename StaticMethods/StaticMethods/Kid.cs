using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    public class Kid
    {
        public void CallTheCat(Cat cat)
        {
            Console.WriteLine("Come, " + cat.Name);
        }

        //public void WagTheCat(Cat cat)
        //{
        //    cat.Meow();
        //}
    }
}
