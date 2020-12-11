using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var random = new Random(1);
            var random = new Random();

            /*
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(random.Next());
                //Console.WriteLine(random.Next(11));
                //Console.WriteLine(random.Next(5, 11));
                //SimpleMethod(random);

                //Console.WriteLine(random.NextDouble());
                Console.WriteLine(random.NextDouble()*10);
            }*/

            var people = new List<PersonModel>
            {
                new PersonModel { FirstName = "Calin" },
                new PersonModel { FirstName = "Cami" },
                new PersonModel { FirstName = "Vasile" },
                new PersonModel { FirstName = "Ionel" },
                new PersonModel { FirstName = "Maria" },
                new PersonModel { FirstName = "Giorgica" }
            };

            //var sortedPeople = people.OrderBy(x => x.FirstName);
            var sortedPeople = people.OrderBy(x => random.Next());

            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);
            }
            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next());
        }
    }
}
