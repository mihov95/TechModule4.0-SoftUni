using System;
using System.Linq;

namespace _01ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;

            // Чета input от конзолата и в същото време гледам дали е "end"            
            while ((input = Console.ReadLine()) != "end")
            {
                // inputa е просто char array! с метода ToArray правя inputa на масив после с метода Reverse ги обръщам (нарочно използвам този подход щото ти дава бързина!)
                var reversedString = input.ToArray().Reverse();

                // Принтирам резултата като тъй като reversedString в момента е масив с метода string.Join го превръщам обратно към string
                Console.WriteLine($"{input} = {string.Join("", reversedString)}");
            }
        }
    }
}
