using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            // tasks - Stack
            // threads - Queue
            // tasks to kill

            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            int valueOfTask = int.Parse(Console.ReadLine());

            while (tasks.Any() && threads.Any())
            {
                int thread = threads.Peek();
                int task = tasks.Peek();

                if (thread >= task)
                {
                    if (task == valueOfTask)
                    {
                        Console.WriteLine($"Thread with value {thread} killed task {valueOfTask}");
                        break;
                    }
                    tasks.Pop();
                    threads.Dequeue();
                }
                else if (thread < task)
                {
                    if (task == valueOfTask)
                    {
                        Console.WriteLine($"Thread with value {thread} killed task {valueOfTask}");
                        break;
                    }
                    threads.Dequeue();
                }
            }

            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
