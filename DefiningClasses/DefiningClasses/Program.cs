﻿using System;


namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateDogs();
            CreateCat();
        }

        static void CreateDogs()
        {
            string firstDogName = null;
            Console.WriteLine("Enter the first dog name: ");
            firstDogName = Console.ReadLine();

            // Using a constructor to create a dog with specified name
            Dog firstDog = new Dog(firstDogName);

            // Using a constructor to create a dog wit a default name
            Dog secondDog = new Dog();

            Console.WriteLine("Enter second dog name: ");
            string secondDogName = Console.ReadLine();

            // Using property to set the name of the dog
            secondDog.Name = secondDogName;

            // Creating a dog with a default name
            Dog thirdDog = new Dog();

            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

            foreach (Dog dog in dogs)
            {
                dog.Bark();
            }
        }

        static void CreateCat()
        {
            Cat cat = new Cat();

            Console.WriteLine("Cat's name is: " + cat.name);
            Console.WriteLine("Dog's age is: " + cat.age);
            Console.WriteLine("Dog's length is: " + cat.length);
            Console.WriteLine("Dog is male: " + cat.isMale);
        }
    }
}
