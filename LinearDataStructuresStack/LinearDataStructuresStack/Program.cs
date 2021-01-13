using System;
using System.Collections.Generic;

namespace LinearDataStructuresStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = "1 + (3 + 2 - (2+3)*4 - ((3+1)*(4-2)))";
            CheckBrackets(expression);

            //CreateStack();
        }
        

        static bool CheckBrackets(string expression)
        {
            
            Stack<int> stack = new Stack<int>();

            bool correctBrackets = true;

            for (int index = 0; index < expression.Length; index++)
            {
                char ch = expression[index];
                if (ch == '(')
                {
                    stack.Push(index);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                    {
                        correctBrackets = false;
                        break;
                    }
                    stack.Pop();
                }
            }
            if (stack.Count != 0)
            {
                correctBrackets = false;
            }
            Console.WriteLine("Are the brackets correct? " + correctBrackets);
            return correctBrackets;
        }

        static void CreateStack()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("1. John");
            stack.Push("2. Nicolas");
            stack.Push("3. Mary");
            stack.Push("4. George");
            Console.WriteLine("Top = " + stack.Peek());
            
            while (stack.Count > 0)
            {
                string personeName = stack.Pop();
                Console.WriteLine(personeName);
            }
        }
    }
}
