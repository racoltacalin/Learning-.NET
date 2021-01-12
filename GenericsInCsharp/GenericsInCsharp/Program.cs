using System;

namespace GenericsInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalShelter<Dog> shelter = new AnimalShelter<Dog>();
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());
            shelter.Shelter(new Dog());
            Dog d = shelter.Release(1); // Release the second dog
            Console.WriteLine(d);
            d = shelter.Release(0); // Release the first dog
            Console.WriteLine(d);
            d = shelter.Release(0); // Release the third dog
            Console.WriteLine(d);
            //d = shelter.Release(0); // Exception: invalid cell index

            /*
            int num1 = 3;
            int num2 = 5;
            Console.WriteLine("Before swap: num1 = {0} | num2 = {1}", num1, num2);
            //Invoking the method with concrete type (int)
            Swap<int>(ref num1, ref num2);
            Console.WriteLine("After  swap: num1 = {0} | num2 = {1}\n", num1, num2);

            string str1 = "Hello";
            string str2 = "There";
            Console.WriteLine("Before swap: str1 = {0} | str2 = {1}", str1, str2);
            //Invoking the method with concrete type (int)
            Swap<string>(ref str1, ref str2);
            Console.WriteLine("After  swap: str1 = {0} | str2 = {1}\n", str1, str2);
            */

            /*
            AnimalShelter<Dog> dogsShelter = new AnimalShelter<Dog>(10);
            AnimalShelter<Cat> catsShelter = new AnimalShelter<Cat>(15);
            
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();
            Dog dog3 = new Dog();

            dogsShelter.Shelter(dog1);
            dogsShelter.Shelter(dog2);
            dogsShelter.Shelter(dog3);

            dogsShelter.Release(1); // Releasing dog2;

            Cat cat1 = new Cat();
            Cat cat2 = new Cat();
            Cat cat3 = new Cat();
            Cat cat4 = new Cat();
            
            catsShelter.Shelter(cat1);
            catsShelter.Shelter(cat2);
            catsShelter.Shelter(cat3);
            catsShelter.Shelter(cat4);

            catsShelter.Release(3); // Releasing cat3;
            */
        }

        public static void Swap<K> (ref K a, ref K b)
        {
            K oldA = a;
            a = b;
            b = oldA;
        }
    }
}
