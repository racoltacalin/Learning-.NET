using System;
using System.IO;

namespace TextFilesInCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Example.CountWord();

            //ReadFileCatchingException();

            //WriteInFile();

            //ReadFileLineByLine();

            /*
            // Create a StreamReader connected to a file
            StreamReader reader = new StreamReader("test.txt");

            // Read the file here...

            // Close the reader resource after you've finished using it
            reader.Close();
            */
        }

        static void ReadFileLineByLine()
        {
            string filePath = @"C:\Users\racol\OneDrive\Desktop\C# Learning\Learning_C#\Learning-.NET\TextFilesInCsharp\TextFilesInCsharp\Sample.txt";
            // Create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader(filePath);

            using (reader)
            {
                int lineNumber = 0;

                // Read first line from the text file
                string line = reader.ReadLine();

                // Read the other lines from the text file
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("Line {0} : {1}", lineNumber, line);
                    line = reader.ReadLine();
                }
            }


            /*
            int lineNumber = 0;

            // Read first line from the text file
            string line = reader.ReadLine();

            // Read the other lines from the text file
            while (line != null)
            {
                lineNumber++;
                Console.WriteLine("Line {0}: {1}", lineNumber, line);
                line = reader.ReadLine();
            }

            // Close the resource after you've finished using it
            reader.Close();
            */
        }

        public static void WriteInFile()
        {
            // Create a StreamWriter instance
            StreamWriter writer = new StreamWriter("numbers.txt");

            // Ensure the writer will be closed when no longer used
            using (writer)
            {
                // Loop through the numbers from 1 to 20 and write them
                for (int i = 1; i <= 20; i++)
                {
                    writer.WriteLine(i);
                }
            }
        }


        public static void ReadFileCatchingException()
        {
            string fileName = @"C:\Users\racol\OneDrive\Desktop\C# Learning\Learning_C#\Learning-.NET\TextFilesInCsharp\TextFilesInCsharp\Sample1.txt";
            try
            {
                StreamReader reader = new StreamReader(fileName);
                Console.WriteLine("File {0} successfully opened.", fileName);
                Console.WriteLine("File contents: ");
                using (reader)
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Cant not find file {0}.", fileName);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch (IOException)
            {
                Console.Error.WriteLine(
                "Can not open the file {0}", fileName);
            }
        }
    }
}
