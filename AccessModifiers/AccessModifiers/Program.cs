using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var demo = new AccessDemo();
            var bad = new BadClass();

            bad.Age = 150;
            bad._age = 150;
            //bad._ssn;

            demo.PublicDemo();
        }

        private static void SayHello()
        {
            Console.WriteLine("Hello user!");
        }
    }
}

 