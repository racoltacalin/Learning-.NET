using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ChoosingTheRightDataStructure
{
    class Program
    {
        static string[] words = { "ocean", "beer", "money", "happiness" };
        static void Main(string[] args)
        {
            PhoneBookFinder.ReadPhoneBook();
            PhoneBookFinder.ProcessQueries();

            //SortingPhoneBook();

            //Student.ReadFile();

            //GenerateSubset2();
            //GenerateSubset1();
        }

        public static void SortingPhoneBook()
        {
            // Read the file and build the phone book
            SortedDictionary<string, SortedDictionary<string, string>> phonesByTown = new SortedDictionary<string, SortedDictionary<string, string>>();

            string filePath = @"C:\Users\racol\OneDrive\Desktop\C# Learning\Learning_C#\Learning-.NET\ChoosingTheRightDataStructure\ChoosingTheRightDataStructure\PhoneBookFile.txt";
            StreamReader reader = new StreamReader(filePath);

            using (reader)
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] entry = line.Split(new char[] { '|' });
                    string name = entry[0].Trim();
                    string town = entry[1].Trim();
                    string phone = entry[2].Trim();

                    SortedDictionary<string, string> phoneBook;
                    if (! phonesByTown.TryGetValue(town, out phoneBook))
                    {
                        // This town is new. Create a phone book for it
                        phoneBook = new SortedDictionary<string, string>();
                        phonesByTown.Add(town, phoneBook);
                    }
                    phoneBook.Add(name, phone);
                }
            }

            // Print the phone book by towns
            foreach (string town in phonesByTown.Keys)
            {
                Console.WriteLine("Town " + town + ":");
                SortedDictionary<string, string> phoneBook = phonesByTown[town];

                foreach (var entry in phoneBook)
                {
                    string name = entry.Key;
                    string phone = entry.Value;
                    Console.WriteLine("\t{0} - {1}", name, phone);
                }
            }


        }

        public static void GenerateSubset1()
        {
            string[] words = { "ocean", "beer", "money", "happiness" };

            Queue<HashSet<string>> subsetsQueue = new Queue<HashSet<string>>();
            HashSet<string> emptySet = new HashSet<string>();
            subsetsQueue.Enqueue(emptySet);

            while (subsetsQueue.Count > 0)
            {
                HashSet<String> subset = subsetsQueue.Dequeue();

                // Print current subset
                Console.Write("{ ");
                foreach (string word in subset)
                {
                    Console.Write("{0} ", word);
                }

                Console.Write("}");
                Console.WriteLine();

                // Generate and enqueue all possible child subsets
                foreach (string element in words)
                {
                    if (! subset.Contains(element))
                    {
                        HashSet<string> newSubset = new HashSet<string>();
                        newSubset.UnionWith(subset);
                        newSubset.Add(element);
                        subsetsQueue.Enqueue(newSubset);
                    }
                }
            }
        }

        public static void GenerateSubset2()
        {
            Queue<List<int>> subsetsQueue = new Queue<List<int>>();
            List<int> emptySet = new List<int>();
            subsetsQueue.Enqueue(emptySet);

            while (subsetsQueue.Count > 0)
            {
                List<int> subset = subsetsQueue.Dequeue();
                Print(subset);

                int start = -1;
                if (subset.Count > 0)
                {
                    start = subset[subset.Count - 1];
                }

                for (int i = start + 1; i < words.Length; i++)
                {
                    List<int> newSubset = new List<int>();
                    newSubset.AddRange(subset);
                    newSubset.Add(i);
                    subsetsQueue.Enqueue(newSubset);
                }
            }
        }

        static void Print(List<int> subset)
        {
            Console.Write("[");
            for (int i = 0; i < subset.Count; i++)
            {
                int index = subset[i];
                Console.Write("{0} ", words[index]);
            }
            Console.WriteLine("]");
        }
    }
}
