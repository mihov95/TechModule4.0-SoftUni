using System;
using System.Dynamic;
using System.Linq;

namespace _06ReplaceRepeatingChar
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var charArr = input.ToCharArray();


            for (int i = 0; i < charArr.Length; i++)
            {
                var currChar = charArr[i];

                if (charArr.Contains(currChar))
                {
                    charArr[i]=
                }
            }
        }
    }
}
