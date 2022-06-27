using System;
using System.Linq;

namespace Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int counter = 0;

            if (matrix.GetLength(0) >= 2 && matrix.GetLength(1) >= 2)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    {
                        if (matrix[row, col] == matrix[row, col + 1] &&
                            matrix[row, col] == matrix[row + 1, col] &&
                            matrix[row, col] == matrix[row + 1, col + 1])
                        {
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
