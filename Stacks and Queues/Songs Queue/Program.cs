using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsArray = Console.ReadLine().Split(", ").ToArray();
            Queue<string> songs = new Queue<string>(songsArray);

            while (songs.Any())
            {
                string input = Console.ReadLine();
                string action = string.Empty;

                if (input.Contains("Add"))
                {
                    string[] inputArray = input.Split("Add ").ToArray();
                    action = inputArray[0];
                    string song = inputArray[1];

                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }
                else
                {
                    action = input;

                    switch (action)
                    {
                        case "Play":
                            songs.Dequeue();
                            break;
                        case "Show":
                            Console.WriteLine(String.Join(", ", songs));
                            break;
                        default:
                            break;
                    }
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
