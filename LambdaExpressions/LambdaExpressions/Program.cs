using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Dog> dogs = new List<Dog>()
            {
                new Dog {Name = "Rex", Age = 4 },
                new Dog {Name = "Bella", Age = 8 },
                new Dog {Name = "Stacy", Age = 3 }
            };
            var names = dogs.Select(x => x.Name);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            // Using Lambda Expressions with Anonymous Types
            var newDogsList = dogs.Select(x => new { Age = x.Age, FirstLetter = x.Name[0] });
            foreach (var item in newDogsList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            // Sorting with Lambda Expressions
            var sortedDogs = dogs.OrderByDescending(x => x.Age);
            foreach (var dog in sortedDogs)
            {
                Console.WriteLine(string.Format("Dog {0} is {1} years old.", dog.Name, dog.Age));
            }


            /*
            // Statements in Lambda Expressions
            List<int> list = new List<int>() { 20, 1, 4, 8, 9, 44 };
            // Process each argument with code statements
            var evenNumbers = list.FindAll((i) =>
            {
                Console.WriteLine("Value of i is: {0}", i);
                return (i % 2) == 0;
            });
            */

            /*
            // Lambda Expressions
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);

            foreach (var num in evenNumbers)
            {
                Console.Write("{0} ", num);
            }

            Console.WriteLine();
            */

            /*
            //Lambda Expressions as Delegates
            Func<bool> boolFunc = () => true;
            Func<int, bool> intFunc = (x) => x < 10;
            if (boolFunc() && intFunc(5))
            {
                Console.WriteLine("5 < 10");
            }
            */
        }
    }
}
