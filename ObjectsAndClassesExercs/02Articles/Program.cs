using System;

namespace _02Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            var numMessages = int.Parse(Console.ReadLine());

            var phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            var events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            var authors = new string[]
            {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            var cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var random = new Random();

            for (int i = 0; i < numMessages; i++)
            {
                var phrase = phrases[random.Next(numMessages)];
                var @event = events[random.Next(numMessages)];
                var author = authors[random.Next(numMessages)];
                var city = cities[random.Next(numMessages)];

                Console.WriteLine($"{phrase} {@event} {author} – {city}.");
            }
        }
    }
}
