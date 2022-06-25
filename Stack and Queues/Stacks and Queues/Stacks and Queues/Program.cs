using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0]; //number of elements to push
            int S = input[1]; //number of elements to pop
            int X = input[2]; //element to look for
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            for (int i = 0; i < S; i++)
            {
                if (stack.Any())
                {
                    stack.Pop();
                }
            }

            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (stack.Any())
            {
                Console.WriteLine(stack.Min());
            }
            else
            {
                Console.WriteLine("0");
            }

        }
    }
}
