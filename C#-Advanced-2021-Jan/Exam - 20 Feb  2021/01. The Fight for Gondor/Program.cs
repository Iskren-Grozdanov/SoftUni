using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1.TheFightForGondoor
{
    class Program
    {
        static void Main(string[] args)
        {
            //shields = queue
            //orcs = stack


            int n = int.Parse(Console.ReadLine());

            var shields = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var queue = new Queue<int>(shields);

            string orcsLeft = "";

            bool flag = false;

            for (int i = 1; i <= n; i++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                var orcs = new Stack<int>(input);

                int count = orcs.Count;

                if (i % 3 == 0)
                {
                    int def = int.Parse(Console.ReadLine());

                    queue.Enqueue(def);
                }

                for (int j = 0; j < count; j++)
                {
                    int orc = orcs.Peek();
                    int defenceCur = queue.Peek();

                    if (defenceCur == orc)
                    {
                        orcs.Pop();
                        queue.Dequeue();
                    }

                    else if (defenceCur > orc)
                    {
                        defenceCur -= orc;
                        orcs.Pop();
                        queue.Dequeue();
                        queue.Enqueue(defenceCur);

                        for (int k = 0; k < queue.Count - 1; k++)
                        {
                            queue.Enqueue(queue.Dequeue());
                        }
                    }

                    else if (orc > defenceCur) //NB
                    {

                        orc -= defenceCur;

                        queue.Dequeue();
                        orcs.Pop();
                        orcs.Push(orc);

                    }

                    if (!queue.Any())
                    {
                        flag = true;

                        orcsLeft = string.Join(", ", orcs);

                        break;
                    }
                }

                if (flag)
                {
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {orcsLeft}");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", queue)}");
            }
        }
    }
}
