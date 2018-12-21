using System;
using System.Collections.Generic;

namespace _02RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var first = random.Next(0, words.Length);
                var second = random.Next(0, words.Length);

                var tempValue = words[i];
                words[i] = words[first];
                words[first] = tempValue;
            }

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
