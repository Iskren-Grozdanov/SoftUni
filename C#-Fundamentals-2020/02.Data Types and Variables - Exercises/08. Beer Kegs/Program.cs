using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte kegs = byte.Parse(Console.ReadLine());
            double maxVolume = double.MinValue;
            string biggestKen = string.Empty;

            for (int i = 0; i < kegs; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKen = model;
                }
            }
            Console.WriteLine(biggestKen);
        }
    }
}
