using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];
            char[] snake = Console.ReadLine().ToCharArray();
            Queue<char> snakeQueue = new Queue<char>(snake);

            bool directionToRight = true;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (directionToRight)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snakeQueue.Dequeue();
                        snakeQueue.Enqueue(matrix[row, col]);
                    }

                    directionToRight = false;
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeQueue.Dequeue();
                        snakeQueue.Enqueue(matrix[row, col]);
                    }

                    directionToRight = true;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
