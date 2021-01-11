using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Monkey
    {
        private string name = "MonMon";

        private void SayHello()
        {
            Console.WriteLine("hELLO Hello!");
        }

        /*
        static void Main()
        {
            Monkey myMonkey = new Monkey();
            Console.WriteLine("My monky's name is " + myMonkey.name);
            myMonkey.SayHello();
        }
        */
    }
}
