using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> ordersQueue = new Queue<int>(orders);

            Console.WriteLine(ordersQueue.Max());

            bool hasFood = true;

            while (hasFood && ordersQueue.Any())
            {
                int currentOrder = ordersQueue.Peek();

                if (foodQuantity - currentOrder >= 0)
                {
                    foodQuantity -= currentOrder;
                    ordersQueue.Dequeue();
                }
                else
                {
                    hasFood = false;
                }
            }

            if (ordersQueue.Any())
            {
                Console.WriteLine($"Orders left: {String.Join(" ", ordersQueue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }


        }
    }
}
