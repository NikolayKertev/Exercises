using System;
using System.Collections.Generic;
using System.Linq;

namespace Max_nad_Min_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int action = input[0];

                switch (action)
                {
                    case 1:
                        int number = input[1];
                        stack.Push(number);
                        break;
                    case 2:
                        if (stack.Any())
                        {
                            stack.Pop();
                        }

                        break;
                    case 3:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case 4:
                        if (stack.Any())
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
