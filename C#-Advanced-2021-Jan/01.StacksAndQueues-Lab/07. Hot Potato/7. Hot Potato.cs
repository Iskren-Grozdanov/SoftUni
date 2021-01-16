using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(names);
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (queue.Count > 1)
            {
                count++;
                string kid = queue.Dequeue();

                if (count == n)
                {
                    count = 0;
                    Console.WriteLine("Removed " + kid);
                }
                else
                {
                    queue.Enqueue(kid);

                }
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
