using System;

namespace _03Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string strToSubstring = Console.ReadLine();
            string text = Console.ReadLine();

            var startIndex = text.IndexOf(strToSubstring);

            while (startIndex != -1)
            {
            text = text.Remove(startIndex, strToSubstring.Length);
                startIndex = text.IndexOf(strToSubstring);
            }


            Console.WriteLine(text);


        }
    }
}
