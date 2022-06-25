using System;
using System.Collections.Generic;
using System.Linq;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());
            Queue<int[]> pumpStations = new Queue<int[]>();

            int currentPetrol = 0;

            for (int i = 0; i < pumps; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                pumpStations.Enqueue(input);
            }

            int startPump = 0;

            for (int i = 0; i < pumps; i++)
            {
                Queue<int[]> currentPumps = new Queue<int[]>(pumpStations);
                bool isCompleted = true;

                while (currentPumps.Any())
                {
                    int[] pumpInfo = currentPumps.Peek();
                    currentPetrol += pumpInfo[0];
                    int distance = pumpInfo[1];

                    if (currentPetrol >= distance)
                    {
                        currentPetrol -= distance;
                        currentPumps.Dequeue();
                    }
                    else
                    {
                        currentPetrol = 0;
                        int[] current = pumpStations.Dequeue();
                        pumpStations.Enqueue(current);
                        isCompleted = false;
                        break;
                    }
                }

                if (isCompleted == false)
                {
                    startPump++;
                }
            }

            Console.WriteLine(startPump);
            
        }
    }
}
