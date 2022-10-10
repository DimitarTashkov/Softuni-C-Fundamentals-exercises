using System;

namespace shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine();
            var fruit = Console.ReadLine();
            var price = double.Parse(Console.ReadLine());
            if (day == "saturday" || day == "sunday" )
            {
                if (fruit == "banana") price = 2.70;
                else if (fruit == "apple") price = 1.25;
                else if (fruit == "orange") price = 0.90;
                else if (fruit == "grapefruit") price = 1.60;
                else if (fruit == "kiwi") price = 3.00;
                else if (fruit == "pineapple") price = 5.60;
                else if (fruit == "grapes") price = 4.20;
            }
            else if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day== "friday" )
            {
                if (fruit == "banana") price = 2.50;
                else if (fruit == "apple") price = 1.20;
                else if (fruit == "orange") price = 0.85;
                else if (fruit == "grapefruit") price = 1.45;
                else if (fruit == "kiwi") price = 2.70;
                else if (fruit == "pineapple") price = 5.50;
                else if (fruit == "grapes") price = 3.85;
            }
            else
            {
                Console.WriteLine("Not a valid date");
            }
            
        }
    }
}
