using System;
using System.Text;

namespace StringsAndTextProcessing
{
    class Program 
    {
        static void Main(string[] args)
        {


            string declared = "Intern pool";
            string built = new StringBuilder("Intern pool").ToString();
            string interned = string.Intern(built);
            Console.WriteLine(object.ReferenceEquals(declared, built));
            Console.WriteLine(object.ReferenceEquals(declared, interned));

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
