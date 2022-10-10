using System;

namespace Magazin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("избери продукт:");
            var product = Console.ReadLine().ToLower();
            Console.WriteLine("избери град:");
            var town = Console.ReadLine().ToLower();
            Console.WriteLine("избери количество:");
            var quantity = double.Parse(Console.ReadLine());
            if (town == "sofia")
            {
                if (product == "coffee")
                    Console.WriteLine(0.50 * quantity);
            }
            if (town == "varna")
            {
                if (product == "coffee")
                    Console.WriteLine(0.45 * quantity);
            }
            if (town == "plovdiv")
            {
                if (product == "coffee")
                    Console.WriteLine(0.40 * quantity);
            }
            if (town == "sofia")
            {
                if (product == "water")
                    Console.WriteLine(0.80 * quantity);
            }
            if (town == "varna")
            {
                if (product == "water")
                    Console.WriteLine(0.70 * quantity);
            }
            if (town == "plovdiv")
            {
                if (product == "water")
                    Console.WriteLine(0.70 * quantity);
            }
            if (town == "sofia")
            {
                if (product == "beer")
                    Console.WriteLine(1.20 * quantity);
            }
            if (town == "varna")
            {
                if (product == "beer")
                    Console.WriteLine(1.15 * quantity);
            }
            if (town == "plovdiv")
            {
                if (product == "beer")
                    Console.WriteLine(1.10 * quantity);
            }
            if (town == "sofia")
            {
                if (product == "sweets")
                    Console.WriteLine(1.45 * quantity);
            }
            if (town == "varna")
            {
                if (product == "sweets")
                    Console.WriteLine(1.30 * quantity);
            }
            if (town == "plovdiv")
            {
                if (product == "sweets")
                    Console.WriteLine(1.35 * quantity);
            }
            if (town == "sofia")
            {
                if (product == "peanuts")
                    Console.WriteLine(1.60 * quantity);
            }
            if (town == "varna")
            {
                if (product == "peanuts")
                    Console.WriteLine(1.50 * quantity);
            }
            if (town == "plovdiv")
            {
                if (product == "peanuts")
                    Console.WriteLine(1.55 * quantity);
            }
           
        }
    }
        
    
    
   
} 
