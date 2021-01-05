using System;

namespace AllAboutArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse_Array();
            Read_Array_From_Console();
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
    }
}
