using System;
using System.Text;

namespace StringsAndTextProcessing
{
    class Program 
    {
        static void Main(string[] args)
        {


            /*
            string doc = "Hello, some@gmail.com, " + "you have been using some@gmail.com in your registration.";
            string fixedDoc = doc.Replace("some@gmail.com", "john@smith.com");
            Console.WriteLine(fixedDoc);
            */

            /*
            string listOfBeers = "Amstel, Heineken, Tuborg, Becks";
            char[] separators = new char[] { ' ', ',', '.' };
            string[] beersArr = listOfBeers.Split(separators);

            foreach (string beer in beersArr)
            {
                if (beer != "")
                {
                    Console.WriteLine(beer);
                }
            }

            string[] bbersArrWithoutSpaces = listOfBeers.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            */

            /*
            string path = "C:\\Pics\\CoolPic.jpg";
            int index = path.LastIndexOf("\\");
            string fullName = path.Substring(index + 1);
            */

            /*
            string path = "C:\\Pics\\CoolPic.jpg";
            string FileName = path.Substring(8, 7);
            */

            /*
            string quote = "The main intent of the \"Intro C#\"" + " book is to introduce the C# programming to newbies.";
            string keyword = "C#";
            int index = quote.IndexOf(keyword);

            while (index != -1)
            {
                Console.WriteLine("{0} found at index: {1}", keyword, index); 
                index = quote.IndexOf(keyword, index + 1);
            }
            */

            /*
            string str = "C# Programming Course";

            int index = str.IndexOf("C#");
            index = str.IndexOf("Course");
            index = str.IndexOf("COURSE");
            index = str.IndexOf("ram");
            index = str.IndexOf("r");
            index = str.IndexOf("r", 5);
            index = str.IndexOf("r", 10);
            */

            /*
            string book = "Introduction to C# book";
            int index = book.IndexOf("C#");

            Console.WriteLine(index);
            */

            /*
            string pass1 = "PasswoRd";
            string pass2 = "PaSSwoRD";
            string pass3 = "password";

            Console.WriteLine(pass1.ToUpper() == "PASSWORD");
            Console.WriteLine(pass2.ToUpper() == "PASSWORD");
            Console.WriteLine(pass3.ToUpper() == "PASSWORD");
            */

            /*
            string text = "All Kind OF LeTTers";
            Console.WriteLine(text.ToLower());
            */

            /*
            string declared = "Intern pool";
            string built = new StringBuilder("Intern pool").ToString();
            string interned = string.Intern(built);
            Console.WriteLine(object.ReferenceEquals(declared, built));
            Console.WriteLine(object.ReferenceEquals(declared, interned));
            */

            /*
            string alpha = "alpha";
            string score1 = "sCorE";
            string score2 = "score";
            Console.WriteLine(string.Compare(alpha, score1, false));
            Console.WriteLine(string.Compare(score1, score2, false));
            Console.WriteLine(string.Compare(score1, score2, true));
            Console.WriteLine(string.Compare(score1, score2, StringComparison.CurrentCultureIgnoreCase));
            */

            /*
            string score = "sCore";
            string scary = "scary";
            Console.WriteLine(score.CompareTo(scary));
            Console.WriteLine(scary.CompareTo(score));
            Console.WriteLine(scary.CompareTo(scary));
            */

            /*
            string word1 = "C#";
            string word2 = "c#";
            Console.WriteLine(word1.Equals("C#"));
            Console.WriteLine(word1.Equals(word2));
            Console.WriteLine(word1 == "C#");
            Console.WriteLine(word1 == word2);
            Console.WriteLine(word1.Equals(word2, StringComparison.CurrentCultureIgnoreCase));
            */

            /*
            string message = "This is a sample string message.";
            Console.WriteLine("message = {0}", message);
            Console.WriteLine("message.Length = {0}", message.Length);
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine("message[{0}] = {1}", i, message[i]);
            }
            */
        }
    }
}
