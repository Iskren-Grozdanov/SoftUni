using System;
using System.Linq;
using System.Collections.Generic;

namespace _07SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vip = new HashSet<string>();

            HashSet<string> regular = new HashSet<string>();

            string command = Console.ReadLine();

            while (command != "PARTY")
            {
                foreach (var symbol in command)
                {
                    if (Char.IsDigit(symbol))
                    {
                        vip.Add(command);
                    }
                    else
                    {
                        regular.Add(command);
                    }
                    break;
                }
                command = Console.ReadLine();
            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                if (vip.Contains(input))
                {
                    vip.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }

                input = Console.ReadLine();
            }

            int sum = vip.Count() + regular.Count();

            Console.WriteLine(sum);

            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }
        }
    }
}