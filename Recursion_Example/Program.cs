using System;
using System.ComponentModel;
using System.Globalization;
using System.Threading.Channels;

namespace Recursion_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //CountOccurences(new int[] { 3, 2, 2, 5, 1, -8, 7, 2 }, 2);
            //GetNameForLastDigit();

            //CheckTheNeighbors(1, 4, 2, 5, 3, 7, 4, 8, 5, 9, 6);

            //RunFib();

            /*
            Console.Write("Please insert the value you want to apply factorial: ");
            int a = int.Parse(Console.ReadLine());
            decimal b = FindFactorial(a);
            Console.WriteLine($"{a}! = {b}");
            */

            //RunTheNestedLoops();

            //RunTheNestedLoopsIterative();

            //RunFib();

            //RunFibonacciIterative();

            //FinPathInLabyrinth();

            FindTheWayOutOfLabyrinth();

            Console.ReadLine();
        }

        static void CountOccurences(int[] numbers, int numberToBeCheck)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numberToBeCheck)
                {
                    count += 1;
                }
            }
            Console.WriteLine("Number to be checked: {0} was found {1} times.", numberToBeCheck, count);
        }

        static void GetNameForLastDigit()
        {
            Console.Write("Please insert a number to get the English name of the last digit: ");
            int n = int.Parse(Console.ReadLine());
            n = n % 10;
            Console.WriteLine("The English name of the last digit is: " + GetTheLastDigit(n));
        }

        static string GetTheLastDigit(int digit)
        {
            string lastDigitName;
            switch (digit)
            {
                case 0:
                    lastDigitName = "zero";
                    break;
                case 1:
                    lastDigitName = "one";
                    break;
                case 2:
                    lastDigitName = "two";
                    break;
                case 3:
                    lastDigitName = "three";
                    break;
                case 4:
                    lastDigitName = "four";
                    break;
                case 5:
                    lastDigitName = "five";
                    break;
                case 6:
                    lastDigitName = "six";
                    break;
                case 7:
                    lastDigitName = "seven";
                    break;
                case 8:
                    lastDigitName = "eight";
                    break;
                case 9:
                    lastDigitName = "nine";
                    break;
                default:
                    Console.WriteLine("Invalid digit!");
                    return null;
            }
            return lastDigitName;
        }

        static void CheckTheNeighbors(params int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if ((numbers[i] > numbers[i - 1]) && (numbers[i] > numbers[i + 1]))
                {
                    Console.WriteLine("Number: {0} is grater than {1} and {2}", numbers[i], numbers[i - 1], numbers[i + 1]);
                }
            }
        }

        static long Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }

        /*
        static void PrintFibNumbers(long number)
        {
            for (int i = 0; i < number.ToString().Length; i++)
            {
                Console.WriteLine($"number[{i}] = " + number);
            }   
        }
        static void RunFib()
        {
            Console.Write("Insert n: ");
            int n = int.Parse(Console.ReadLine());
            PrintFibNumbers(Fib(n));
        }
        */

        static decimal FindFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * FindFactorial(n - 1);
            }
        }

        static decimal Factorial(int n)
        {
            decimal result = 1;

            for (int i = 1; i < n; i++)
            {
                result = result * i;
            }

            return result;
        }

        // Nested Loops - Recursive Version
        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }

            for (int counter = 1; counter <= numberOfIterations; counter++)
            {
                loops[currentLoop] = counter;
                NestedLoops(currentLoop + 1);
            }
        }

        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }

        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;

        static void RunTheNestedLoops()
        {
            Console.Write("N = ");
            numberOfLoops = int.Parse(Console.ReadLine());

            Console.Write("K = ");
            numberOfIterations = int.Parse(Console.ReadLine());

            loops = new int[numberOfLoops];

            NestedLoops(0);
        }

        // Nested Loops – Iterative Version
        static void RunTheNestedLoopsIterative()
        {
            Console.Write("N = ");
            numberOfLoops = int.Parse(Console.ReadLine());

            Console.Write("K = ");
            numberOfIterations = int.Parse(Console.ReadLine());

            loops = new int[numberOfLoops];

            NestedLoopsIterative();
        }

        static void NestedLoopsIterative()
        {
            InitLoops();
            int currentPosition;

            while (true)
            {
                PrintLoops();
                currentPosition = numberOfLoops - 1;
                loops[currentPosition] = loops[currentPosition] + 1;

                while (loops[currentPosition] > numberOfIterations)
                {
                    loops[currentPosition] = 1;
                    currentPosition--;

                    if (currentPosition < 0)
                    {
                        return;
                    }
                    loops[currentPosition] = loops[currentPosition] + 1;
                }
            }
        }

        static void InitLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                loops[i] = 1;
            }
        }

        static long[] numbers;

        static void RunFib()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            numbers = new long[n + 2];
            numbers[1] = 1;
            numbers[2] = 1;

            long result = FibonacciOpt(n);
            Console.WriteLine("fib({0}) = {1}", n, result);
        }
        static long FibonacciOpt(int n)
        {
            if (0 == numbers[n])
            {
                numbers[n] = FibonacciOpt(n - 1) + FibonacciOpt(n - 2);
            }
            return numbers[n];
        }

        static void RunFibonacciIterative()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            long result = FibonacciIterative(n);
            Console.WriteLine("fib({0}) = {1}", n, result);
        }

        static long FibonacciIterative(int n)
        {
            long fn = 0;
            long fnMinus1 = 1;
            long fnMinus2 = 1;

            for (int i = 2; i < n; i++)
            {
                fn = fnMinus1 + fnMinus2;
                fnMinus1 = fn;
            }
            return fn;
        }

        // Paths in a Labyrinth - Recursive Algorithm
        static char[,] lab =
        {
            {' ','*',' ',' ',' ',' ','*',' ',' ',' ',' ','*','*',' ',' '},
            {' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ','*','*','*',' ','*',' ',' ',' ',' ',' ','*','*','*','*'},
            {' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ','*',' ',' ',' ',' ',' ',' ',' ',' ','e'}
        };

        /*
        static char[,] lab =
        {
        {' ', ' ', ' ', '*', ' ', ' ', ' '},
        {'*', '*', ' ', '*', ' ', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', ' '},
        {' ', '*', '*', '*', '*', '*', ' '},
        {' ', ' ', ' ', ' ', ' ', ' ', 'e'},
        };  
        */
        /*
        static char[,] lab =
        {
            {'e'},
        };
        */

        /*
        static char[,] lab =
        {
            {' ', ' ', ' '},
            {' ', ' ', ' '},
            {' ', ' ', 'e'},
        };
        */

        /*
        static char[,] lab =
        {
            {' ', '*', '*', ' ', ' '},
            {' ', ' ', ' ', '*', ' '},
            {'*', ' ', ' ', '*', 'e'},
        };
        */

        static void FindPath(int row, int col)
        {
            if ((col < 0) || (row < 0) || (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                // We are out of the labyrinth
                return;
            }

            // Check if we have found the exit
            if (lab[row, col] == 'e')
            {
                Console.WriteLine("Found the exit!");
            }

            if (lab[row, col] != ' ')
            {
                // The current cell is not free
                return;
            }

            // Mark the current cell as visited
            lab[row, col] = 's';
            for (int j = 0; j < lab.Length; j++)
            {
                Console.WriteLine($"[{row}, {col}]");
            }

            // Invoke recursion to explore all possible directions
            FindPath(row, col - 1); // left
            FindPath(row - 1, col); // up
            FindPath(row, col + 1); // right
            FindPath(row + 1, col); // down

            /*
            // Mark back the current cell as free
            lab[row, col] = ' ';
            */
        }

        static void FinPathInLabyrinth()
        {
            FindPath(0, 0);
        }

        // Paths in a Labyrinth – Saving the Paths
        static char[] path = new char[lab.GetLength(0) * lab.GetLength(1)];
        static int position = 0;
        static void SavingTheFindedPath(int row, int col, char direction)
        {
            if ((col < 0) || (row < 0) ||
            (col >= lab.GetLength(1)) || (row >= lab.GetLength(0)))
            {
                // We are out of the labyrinth
                return;
            }
            // Append the direction to the path
            path[position] = direction;
            position++;

            // Check if we have found the exit
            if (lab[row, col] == 'e')
            {
                PrintPathSaved(path, 1, position - 1);
            }
            if (lab[row, col] == ' ')
            {
                // The current cell is free. Mark it as visited
                lab[row, col] = 's';
                // Invoke recursion to explore all possible directions
                SavingTheFindedPath(row, col - 1, 'L'); // left
                SavingTheFindedPath(row - 1, col, 'U'); // up
                SavingTheFindedPath(row, col + 1, 'R'); // right
                SavingTheFindedPath(row + 1, col, 'D'); // down
                                                        // Mark back the current cell as free
                lab[row, col] = ' ';
            }
            // Remove the last direction from the path
            position--;
        }
        static void PrintPathSaved(char[] path, int startPos, int endPos)
        {
            Console.Write("Found path to the exit: ");
            for (int pos = startPos; pos <= endPos; pos++)
            {
                Console.Write(path[pos]);
            }
            Console.WriteLine();
        }

        static void FindTheWayOutOfLabyrinth()
        {
            SavingTheFindedPath(0, 0, 'S');
        }
    } 
}