using System;
using System.Collections.Generic;
using System.Text;


namespace InterviewPrep_Example
{
    public class StackExample
    {
        static void Main()
        {
            CreateStack();
        }


        public static void CreateStack()
        {
            Stack<int> newStack = new Stack<int>();
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);
            newStack.Push(4);
            newStack.Push(5);
            foreach (var item in newStack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            newStack.Pop();
            foreach (var item in newStack)
            {
                Console.WriteLine(item);
            }
        }


    }
}
