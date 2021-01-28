using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCount++;
                }

                if (i % 3 == 0)
                {
                    mouseCount++;
                }

                if (i % 2 == 0 && i % 3 == 0)
                {
                    keyboardCount++;

                    if (keyboardCount % 2 == 0)
                    {
                        displayCount++;
                    }

                }

            }

            double allHeadset = headsetPrice * headsetCount;
            double allMouse = mousePrice * mouseCount;
            double allKeyboard = keyboardPrice * keyboardCount;
            double allDisplay = displayPrice * displayCount;

            double totalAll = allHeadset + allDisplay + allKeyboard + allMouse;

            Console.WriteLine($"Rage expenses: {totalAll:f2} lv.");
        }
    }
}
