using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());

            int[] bulletsSequence = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] locksSequence = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsSequence);
            Queue<int> locks = new Queue<int>(locksSequence);

            int bulletsShot = 0;

            while (bullets.Any() && locks.Any())
            {
                int currBullet = bullets.Peek();
                int currLock = locks.Peek();

                if (currBullet <= currLock)
                {
                    Console.WriteLine("Bang!");
                    bullets.Pop();
                    locks.Dequeue();
                    bulletsShot++;
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                    bulletsShot++;
                }

                if (bullets.Any() && bulletsShot % gunBarrelSize == 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence - (bulletsShot * bulletPrice)}");
            }
        }
    }
}
