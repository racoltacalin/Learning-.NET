using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    public class Cat
    {
        private string name = "Catty";
        public string Name
        {
            get { return this.name; }

        }

        public void Meow()
        {
            Console.WriteLine("meow-meow");
        }

        public void DoSomething()
        {
            this.Meow();
        }
    }
}
