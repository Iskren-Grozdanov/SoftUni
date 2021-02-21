using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue - effects 
            //Stack - casings

            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Stack<int> casings = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("Datura Bombs", 0);
            dictionary.Add("Cherry Bombs", 0);
            dictionary.Add("Smoke Decoy Bombs", 0);
            bool isReady = false;

            while (effects.Any() && casings.Any())
            {
                int effect = effects.Peek();
                int casing = casings.Peek();

                if (effect + casing == 40)
                {
                    dictionary["Datura Bombs"]++;
                    effects.Dequeue();
                    casings.Pop();
                }
                else if (effect + casing == 60)
                {
                    dictionary["Cherry Bombs"]++;
                    effects.Dequeue();
                    casings.Pop();
                }
                else if (effect + casing == 120)
                {
                    dictionary["Smoke Decoy Bombs"]++;
                    effects.Dequeue();
                    casings.Pop();
                }
                else
                {
                    casings.Pop();
                    casing -= 5;
                    casings.Push(casing);
                    continue;
                }

                isReady = dictionary["Datura Bombs"] >= 3 && dictionary["Cherry Bombs"] >= 3 && dictionary["Smoke Decoy Bombs"] >= 3;

                if (isReady)
                {
                    break;
                }
            }

            if (isReady)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (!effects.Any())
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");
            }

            if (!casings.Any())
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casings)}");
            }

            foreach (var (type, value) in dictionary.OrderBy(t => t.Key))
            {
                Console.WriteLine($"{type}: {value}");
            }
        }
    }
}