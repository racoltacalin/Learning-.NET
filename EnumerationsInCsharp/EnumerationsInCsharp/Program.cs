using System;

namespace EnumerationsInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Coffee normalCoffee = new Coffee(CoffeeSize.Normal);
            Coffee doubleCoffee = new Coffee(CoffeeSize.Double);

            Console.WriteLine("The {0} coffee is {1} ml.", normalCoffee.Size, (int)normalCoffee.Size);
            Console.WriteLine("The {0} coffee is {1} ml.", doubleCoffee.Size, (int)doubleCoffee.Size);
        }
    }
}
