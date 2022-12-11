using System;
using System.Linq;
using System.Collections.Generic;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                Random random = new Random();
                int randomPhrase = random.Next(0, phrases.Length);
                int randomEvent = random.Next(0, events.Length);
                int randomauthor = random.Next(0, authors.Length);
                int randomcity = random.Next(0, cities.Length);
                Console.WriteLine($"{phrases[randomPhrase]} {events[randomEvent]} {authors[randomauthor]} – {cities[randomcity]}.");

            }
        }
    }

}
