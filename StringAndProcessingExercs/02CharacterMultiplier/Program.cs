using System;

namespace _02CharacterMultiplier
{
    class Program
    {


        static void Main(string[] args)
        {
            //Create a method that takes two strings as arguments and returns the sum of their character codes multiplied(multiply str1[0] with str2[0] and add to the total sum).

            //Then continue with the next two characters.

            // If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var firstStr = input[0].ToCharArray();
            var secondStr = input[1].ToCharArray();

            int sumOfFirstStr = 0;
            for (int i = 0; i < firstStr.Length; i++)
            {
                int value = firstStr[i];

                sumOfFirstStr += value;
            }

            int sumOfSecondStr = 0;
            for (int i = 0; i < secondStr.Length; i++)
            {
                int value = secondStr[i];

                sumOfSecondStr += value;
            }
            int multiplier = sumOfFirstStr * sumOfSecondStr;


            Console.WriteLine($"First string value - {multiplier}");

        }
    }
}
