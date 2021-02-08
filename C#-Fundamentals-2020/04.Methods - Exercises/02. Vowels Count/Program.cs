using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            int counter = 0;
            for (int i = 0; i < word.Length; i++)
            {

                char currChar = word[i];

                if (currChar == 'a' || currChar == 'e' || currChar == 'i' || currChar == 'o' || currChar == 'u' || currChar == 'y')
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
