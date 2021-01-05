using System;

namespace AllAboutArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse_Array();
            //Read_Array_From_Console();
            Check_The_Symmetric_Array();
            Console.ReadLine();
        }

        public static void Reverse_Array()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int length = array.Length;
            int[] reversed = new int[length];

            for (int index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }

            for (int index  = 0; index  < length; index ++)
            {
                Console.Write(reversed[index] + " ");
            }
        }

        public static void Read_Array_From_Console()
        {
            Console.Write("Insert the length of array: n = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void Check_The_Symmetric_Array()
        {
            Console.Write("Enter a positive integer - length of array: n = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Enter the values of the array: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            bool symmetric = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[n-i-1])
                {
                    symmetric = false;
                    break;
                }
            }
            Console.WriteLine("Is symmetric? {0}", symmetric);
        }
    }
}
