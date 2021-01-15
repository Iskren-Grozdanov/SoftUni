using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>(songs);

            string command = Console.ReadLine();

            while (queue.Any())
            {
                if (command.Contains("Play"))
                {
                    queue.Dequeue();
                }
                if (command.Contains("Add"))
                {
                    var song = command.Substring(4);  // OR command.Split("Add ", StringSplitOptions.RemoveEmptyEntries)[0];

                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                }
                if (command.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
