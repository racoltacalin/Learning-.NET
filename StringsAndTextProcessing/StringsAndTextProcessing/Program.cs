using System;

namespace StringsAndTextProcessing
{
    class Program 
    {
        static void Main(string[] args)
        {
            string word1 = "C#";
            string word2 = "c#";
            Console.WriteLine(word1.Equals("C#"));
            Console.WriteLine(word1.Equals(word2));
            Console.WriteLine(word1 == "C#");
            Console.WriteLine(word1 == word2);



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
