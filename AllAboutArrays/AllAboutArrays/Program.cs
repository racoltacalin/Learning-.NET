using System;

namespace AllAboutArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse_Array();
            //Read_Array_From_Console();
            //Check_The_Symmetric_Array();
            //Double_TheElement_OfArray();
            //Reversed_ByIndex();
            //Declare_MultidimensionalArray();
            //Reading_Matrix_FromConsole();
            //Find_The_SubMatrix();
            Create_Pascal_Triangle();
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

        public static void Double_TheElement_OfArray()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.Write("Output: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= 2;
                Console.Write(array[i] + " ");
            }
        }

        public static void Reversed_ByIndex()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.Write("Reversed: ");
            for (int index = array.Length - 1; index >= 0; index--)
            {
                Console.Write(array[index] + " ");
            }
        }

        public static void Declare_MultidimensionalArray()
        {
            int[,] intMatrix = new int[3, 4]; // rows, columns
            int[,] matrix =
            {
                {1, 2, 3, 4 }, // row 0 - values
                {5, 6, 7, 8 }, // row 1 - values
            };
            // The matrix size is 2 x 4 ( 2 rows, 4 cols ).
            //Console.WriteLine(matrix.GetLength(0));
            //Console.WriteLine(matrix.GetLength(1));

            // Print the matrix on the console
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Reading_Matrix_FromConsole()
        {
            Console.Write("Enter the number of the rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of the columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter the celss of the matrix: ");

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0}, {1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static void Find_The_SubMatrix()
        {
            // Declare and initialize the matrix
            int[,] matrix = 
            {
                { 0, 2, 4, 0, 2, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 3, 5, 6 },
                { 4, 6, 1, 9, 1, 0 }
            };
            // Find the maximal sum platform of size 2 x 2
            long bestSum = long.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    long sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            // Print the result
            Console.WriteLine("The best platform is:");
            Console.WriteLine(" {0} {1}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1]);
            Console.WriteLine(" {0} {1}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1]);
            Console.WriteLine("The maximal sum is: {0}", bestSum);
        }

        public static void Create_Pascal_Triangle()
        {
            Console.WriteLine("Please insert the height of the Pasca's triangle: height = ");
            int height = int.Parse(Console.ReadLine());

            long[][] triangle = new long[height + 1][];

            for (int row = 0; row < height; row++)
            {
                triangle[row] = new long[row + 1];
            }

            // Calculate the Pascal's triangle
            triangle[0][0] = 1;
            for (int row = 0; row < height - 1; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    triangle[row + 1][col] += triangle[row][col];
                    triangle[row + 1][col + 1] += triangle[row][col];
                }
            }

            // Print the Pascal's triangle
            for (int row = 0; row < height; row++)
            {
                Console.Write("".PadLeft((height - row) * 2));
                for (int col = 0; col <= row; col++)
                {
                    Console.Write("{0,3} ", triangle[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
