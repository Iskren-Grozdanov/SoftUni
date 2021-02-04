using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArgs = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string command = inputArgs[0];
                string number = inputArgs[1];

                if (command == "IN")
                {
                    set.Add(number);
                }
                else
                {
                    set.Remove(number);
                }

                input = Console.ReadLine();
            }

            if (!set.Any())
            {
                Console.WriteLine("Parking Lot is Empty");
                return;
            }

            foreach (var item in set)
            {
                Console.WriteLine(item);
            }
        }
    }
}
