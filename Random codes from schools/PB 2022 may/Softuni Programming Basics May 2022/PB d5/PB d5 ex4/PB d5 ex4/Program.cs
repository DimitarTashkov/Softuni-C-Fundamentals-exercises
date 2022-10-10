using System;

namespace PB_d5_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int ribari = int.Parse(Console.ReadLine());

            double shiprentprice = 0;
            switch(season)
            {
                case "Spring":
                    shiprentprice = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    shiprentprice = 4200;
                    break;
                case "Winter":
                    shiprentprice = 2600;   
                    break;
            }
            double discount = 0;
            if (ribari>=4 && ribari <= 6)
            {
                discount = 0.1 * shiprentprice;
            }
            else if (ribari >= 7 && ribari <= 11)
            {
                discount = 0.15 * shiprentprice;
            }
            else if(ribari>=12 && ribari<=18)
            {
                discount = 0.25 * shiprentprice;

            }
            shiprentprice -= discount;
            bool fishermaneven = ribari % 2 == 0;
            if(fishermaneven && season != "Autumn")
            {
                shiprentprice -= 0.05 * shiprentprice;
            }
            if (budget >= shiprentprice)
            {
                double change = budget - shiprentprice;
                Console.WriteLine($"Yes! You have {change:f2} leva left.");
            }
            else
            {
                double insufficient = shiprentprice - budget;
                Console.WriteLine($"Not enough money! You need {insufficient:f2} leva.");
            }
        }
    }
}
