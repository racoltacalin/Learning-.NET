using System;
using System.Collections.Generic;
using System.Collections;
using Generics.WithGenerics;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Not ok to use ArrayList
            ArrayList list = new ArrayList();

            list.Add(23);
            list.Add("Hello");

            int val = (int)list[1]; => Not working*/

            //List<int> ages = new List<int>();
            //var ages = new List<int>();

            //ages.Add(23);
            //ages.Add("Hello");

            //Console.ReadLine();

            DemonstrateTextFileStorage();

            Console.WriteLine();
            Console.Write("Press enter to shut down...");
            Console.ReadLine();
        }

        private static void DemonstrateTextFileStorage()
        {
            var people = new List<Person>();
            var logs = new List<LogEntry>();

            string peopleFile = @"C:\Users\racol\OneDrive\Desktop\C# Learning\Learning_C#\Learning-.NET\Generics\Generics\people.csv";
            string logFile = @"C:\Users\racol\OneDrive\Desktop\C# Learning\Learning_C#\Learning-.NET\Generics\Generics\logs.csv";

            PopulateLists(people, logs);

            /* New way of doing things - generics! */
            GenericTextFileProcessor.SaveToTextFile<Person>(people, peopleFile);
            GenericTextFileProcessor.SaveToTextFile<LogEntry>(logs, logFile);

            var newPeople = GenericTextFileProcessor.LoadFromTextFile<Person>(peopleFile);

            foreach (var p in newPeople)
            {
                Console.WriteLine($"{ p.FirstName } { p.LastName } (IsAlive = { p.IsAlive })");
            }

            Console.WriteLine();

            var newLogs = GenericTextFileProcessor.LoadFromTextFile<LogEntry>(logFile);

            foreach (var log in newLogs)
            {
                Console.WriteLine($"{ log.ErrorCode }: { log.Message } at { log.TimeOfEvent.ToShortTimeString() }");
            }

            /* Old way of doing things - non-generics! */

            //OriginalTextFileProcessor.SaveLogs(logs, logFile);

            //var newLogs = OriginalTextFileProcessor.LoadLogs(logFile);

            //foreach (var log in newLogs)
            //{
            //    Console.WriteLine($"{ log.ErrorCode }: { log.Message } at { log.TimeOfEvent.ToShortTimeString() }");
            //}

            //OriginalTextFileProcessor.SavePeople(people, peopleFile);

            //var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

            //foreach (var p in newPeople)
            //{
            //    Console.WriteLine($"{ p.FirstName } { p.LastName } (IsAlive = { p.IsAlive })");
            //}
        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Calin", LastName = "Corey", IsAlive = true });
            people.Add(new Person { FirstName = "Sue", LastName = "Storm", IsAlive = false });
            people.Add(new Person { FirstName = "Greg", LastName = "Olso" , IsAlive = true });

            logs.Add(new LogEntry { ErrorCode = 9999, Message = "I blew up" });
            logs.Add(new LogEntry { ErrorCode = 1337, Message = "I'm too awesome" });
            logs.Add(new LogEntry { ErrorCode = 2222, Message = "I was tired" });
        }
    }
}
