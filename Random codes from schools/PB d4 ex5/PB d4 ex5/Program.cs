using System;

namespace PB_d4_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            decimal productprice = 0m;
            if(city == "Sofia")
            {
              if(product == "coffee")
                {
                    productprice = 0.50m;
                }
              else if(product == "water")
                {
                    productprice = 0.80m;
                }
                else if (product == "beer")
                {
                    productprice = 1.20m;
                }
                else if (product == "sweets")
                {
                    productprice = 1.45m;
                }
                else if (product == "peanuts")
                {
                    productprice = 1.60m;
                }
            }
            else if(city== "Plovdiv")
            {
                if (product == "coffee")
                {
                    productprice = 0.40m;
                }
                else if (product == "water")
                {
                    productprice = 0.70m;
                }
                else if (product == "beer")
                {
                    productprice = 1.15m;
                }
                else if (product == "sweets")
                {
                    productprice = 1.30m;
                }
                else if (product == "peanuts")
                {
                    productprice = 1.50m;
                }
            }
            else if(city == "Varna")
            {
                if (product == "coffee")
                {
                    productprice = 0.45m;
                }
                else if (product == "water")
                {
                    productprice = 0.70m;
                }
                else if (product == "beer")
                {
                    productprice = 1.10m;
                }
                else if (product == "sweets")
                {
                    productprice = 1.35m;
                }
                else if (product == "peanuts")
                {
                    productprice = 1.55m;
                }
            }
            decimal totalprice = (decimal)quantity * productprice;
            Console.WriteLine(totalprice);

        }
    }
}
