using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());

            while (queue.Any())
            {
                if (quantityOfFood>=queue.Peek())
                {
                    quantityOfFood -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (!queue.Any())
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {String.Join(" ", queue)}");
            }
        }
    }
}
