using System;

namespace nested_cond_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            string daytime = Console.ReadLine();
            string outfit = "";
            string shoes = "";
            if (degrees >= 10 && degrees <18)
            {
                if (daytime == "Morning")
                {
                    outfit = "Sweatshift";
                    shoes = "Sneakers";
                }
                else if (daytime == "Afternoon" || daytime == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees>= 18 && degrees<=24)
            {
            if(daytime == "Morning"|| daytime== "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            else if (daytime =="Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (degrees>=25)
            {
            if (daytime =="Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";

                }
            else if (daytime =="Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }    
            }
            else if (daytime == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}");

        }
    }
}
