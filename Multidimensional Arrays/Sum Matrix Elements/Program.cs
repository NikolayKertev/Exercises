using System;
using System.Linq;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int firstSum = 0;
            int secondSum = 0;

            int[,] matrix = new int[N, N];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                firstSum += matrix[row, row];
                secondSum += matrix[matrix.GetLength(0) - row - 1, row];
            }

            Console.WriteLine(Math.Abs(firstSum - secondSum));
        }
    }
}
