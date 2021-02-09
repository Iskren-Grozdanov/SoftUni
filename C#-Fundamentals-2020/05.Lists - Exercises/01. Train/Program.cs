using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmd = command.Split();

                if (cmd[0] == "Add")
                {
                    wagons.Add(int.Parse(cmd[1]));
                }
                else
                {
                    int passengers = int.Parse(cmd[0]);
                    for (int i = 0; i < wagons.Count(); i++)
                    {
                        int curr = wagons[i];
                        if (curr + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
