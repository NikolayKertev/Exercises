using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] inputArray = Console.ReadLine().Split().ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputArray[col];
                }
            }

            string input = Console.ReadLine();


            while (input != "END")
            {
                string[] commandArgs = input.Split().ToArray();
                string action = commandArgs[0];

                if (commandArgs.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }

                int firstRow = int.Parse(commandArgs[1]);
                int firstCol = int.Parse(commandArgs[2]);
                int secondRow = int.Parse(commandArgs[3]);
                int secondCol = int.Parse(commandArgs[4]);

                if (firstRow < 0 || firstRow > matrix.GetLength(0) - 1 ||
                    firstCol < 0 || firstCol > matrix.GetLength(1) - 1 ||
                    secondRow < 0 || secondRow > matrix.GetLength(0) - 1 ||
                    secondCol < 0 || secondCol > matrix.GetLength(1) - 1)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine();
                    continue;
                }
                string switchNumber = matrix[firstRow, firstCol];
                matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                matrix[secondRow, secondCol] = switchNumber;

                printMatrix(matrix);

                input = Console.ReadLine();
            }
        }

        private static void printMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
