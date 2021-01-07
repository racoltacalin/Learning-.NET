using System;
using System.Text;

namespace CreatingAndUsingObjects
{
    class Program
    {
        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";

        private const string AllChars = CapitalLetters + SmallLetters + Digits + SpecialChars;

        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            GeneratePassword();

            //RandomNumbersBetween1And49();

            //GetElapsedTime();

            //Console.WriteLine("Sequence[1...3]: {0}, {1}, {2}", Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue());

            /*
            Cat firstCat = new Cat();
            firstCat.Name = "Tony";
            firstCat.SayMiau();

            Cat secondCat = new Cat("Pepy", "red");
            secondCat.SayMiau();
            Console.WriteLine("Cat {0} is {1}.", secondCat.Name, secondCat.Color);
            */
        }

        static void GetElapsedTime()
        {
            int sum = 0;
            int startTime = Environment.TickCount;

            // The code fragment to be tested
            for (int i = 0; i < 10000000; i++)
            {
                sum++;
            }

            int endTime = Environment.TickCount;
            Console.WriteLine("The time elapsed is {0} sec.", (endTime - startTime) / 1000.0);
        }

        static void RandomNumbersBetween1And49()
        {
            Random rand = new Random();
            for (int number = 1; number <= 6; number++)
            {
                int randomNumber = rand.Next(49) + 1;
                Console.Write("{0} ", randomNumber);
            }
        }

        static void GeneratePassword()
        {
            StringBuilder password = new StringBuilder();

            // Generate two random capital letters
            for (int i = 0; i <= 2; i++)
            {
                char capitalLetter = GenerateChar(CapitalLetters);
                InsertAtRandomPosition(password, capitalLetter);
            }

            // Generate two random samll letters
            for (int i = 0; i <= 2; i++)
            {
                char smallLetter = GenerateChar(SmallLetters);
                InsertAtRandomPosition(password, smallLetter);
            }

            // Generate two random digits
            for (int i = 0; i <= 2; i++)
            {
                char digit = GenerateChar(Digits);
                InsertAtRandomPosition(password, digit);
            }

            // Generate 3 special characters
            for (int i = 0; i <= 3; i++)
            {
                char specialChar = GenerateChar(SpecialChars);
                InsertAtRandomPosition(password, specialChar);
            }

            // Generate few random characters (between 0 and 7)
            int count = rnd.Next(8);
            for (int i = 1; i <= count; i++)
            {
                char specialChar = GenerateChar(AllChars);
                InsertAtRandomPosition(password, specialChar);
            }
            Console.WriteLine(password);
        }

        private static void InsertAtRandomPosition(StringBuilder password, char character)
        {
            int randomPosition = rnd.Next(password.Length + 1);
            password.Insert(randomPosition, character);
        }
        private static char GenerateChar(string availableChars)
        {
            int randomIndex = rnd.Next(availableChars.Length);
            char randomChar = availableChars[randomIndex];
            return randomChar;
        }
    }
}

