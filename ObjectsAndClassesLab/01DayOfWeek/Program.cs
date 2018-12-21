using System;
using System.Globalization;

namespace _01DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            DateTime date = DateTime.ParseExact(input,
                "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
