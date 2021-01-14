using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsMarksExample
{
    class StudentsExample
    {
        static void Main()
        {
            IDictionary<string, double> studentMarks = new Dictionary<string, double>(6);

            studentMarks["Alan"] = 3.00;
            studentMarks["Helen"] = 4.50;
            studentMarks["Tom"] = 5.50;
            studentMarks["James"] = 3.50;
            studentMarks["Mary"] = 4.00;
            studentMarks["Nerdy"] = 6.00;

            double marysMark = studentMarks["Mary"];
            Console.WriteLine("Mary's mark: {0:0.00}", marysMark);
            studentMarks.Remove("Mary");
            Console.WriteLine("Mary's mark removed");
            Console.WriteLine("Is Mary in the dictionary: {0}", studentMarks.ContainsKey("Mary") ? "Yes!" : "No!");
            Console.WriteLine();

            Console.WriteLine("Nerdy's mark is {0:0.00}.", studentMarks["Nerdy"]);
            studentMarks["Nerdy"] = 3.25;
            Console.WriteLine("But we all know he deserves no more than {0:0.00}.", studentMarks["Nerdy"]);
            Console.WriteLine();

            double annasMarks;
            bool findAnna = studentMarks.TryGetValue("Anna", out annasMarks);
            Console.WriteLine("Is Anna's mark in the dictionary? {0}", findAnna ? "Yes!" : "No!");

            studentMarks["Anna"] = 6.00;
            findAnna = studentMarks.TryGetValue("Anna", out annasMarks);
            Console.WriteLine("Let's try again: {0}. Anna's mark is {1:0.00}", findAnna ? "Yes!" : "No!", annasMarks);
            Console.WriteLine();

            foreach (KeyValuePair<string, double> studentMark in studentMarks)
            {
                Console.WriteLine("{0} has {1:0.00}", studentMark.Key, studentMark.Value);
            }

            Console.WriteLine("Ther are {0} students in the dictionary", studentMarks.Count);
            studentMarks.Clear();
            Console.WriteLine("Students dictionary cleared.");
            Console.WriteLine("Is dictionary empty: {0}", studentMarks.Count == 0);
        }
    }
}
