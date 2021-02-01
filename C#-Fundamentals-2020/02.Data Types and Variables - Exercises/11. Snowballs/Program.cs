using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger biggestValue = 0;
            BigInteger biggestSnow = 0;
            BigInteger biggestTime = 0;
            BigInteger biggestQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowBallValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowBallValue > biggestValue)
                {
                    biggestValue = snowBallValue;
                    biggestSnow = snowballSnow;
                    biggestTime = snowballTime;
                    biggestQuality = snowballQuality;
                }


            }
            Console.WriteLine($"{biggestSnow} : {biggestTime} = {biggestValue} ({biggestQuality})");
        }
    }
}
