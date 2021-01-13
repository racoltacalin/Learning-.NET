using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Threading;

namespace LinearDataStructuresQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            FindTheSequence();

            //CreateQueue();
        }


        static void FindTheSequence()
        {
            int n = 3;
            int p = 16;

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);
            int index = 0;
            Console.Write("S =");
            while (queue.Count > 0)
            {
                index++;
                int current = queue.Dequeue();
                Console.Write(" " + current);
                if (current == p)
                {
                    Console.WriteLine();
                    Console.WriteLine("Index = " + index);
                    return;
                }
                queue.Enqueue(current + 1);
                queue.Enqueue(2 * current);
            }
        }

        static void CreateQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Message One!");
            queue.Enqueue("Message Two!");
            queue.Enqueue("Message Three!");
            queue.Enqueue("Message Four!");

            while (queue.Count > 0)
            {
                string msg = queue.Dequeue();
                Console.WriteLine(msg);
            }

        }
    }
}
