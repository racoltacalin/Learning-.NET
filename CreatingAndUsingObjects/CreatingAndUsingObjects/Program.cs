using System;

namespace CreatingAndUsingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Tony";
            firstCat.SayMiau();

            Cat secondCat = new Cat("Pepy", "red");
            secondCat.SayMiau();
            Console.WriteLine("Cat {0} is {1}.", secondCat.Name, secondCat.Color);
        }
    }
}
