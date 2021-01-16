using System;

namespace UnitTestingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Sum(new int[] { 1, 2 }) != 3)
            {
                throw new Exception("1 + 2 != 3");
            }
        }

        static int Sum(int[] numbers)
        {
            int sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
