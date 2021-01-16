using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>(clothes);
            int racks = 0;
            int sum = 0;

            while (stack.Any())
            {
                int curr = stack.Peek();
                if (sum+curr > capacity)
                {
                    racks++;
                    sum = 0;
                }
                else if (sum + curr == capacity)
                {
                    racks++;
                    sum = 0;
                    stack.Pop();
                }
                else
                {
                    sum += stack.Pop();
                }
            }
            if (sum>0)
            {
                racks++;
            }

            Console.WriteLine(racks);
        }
    }
}
