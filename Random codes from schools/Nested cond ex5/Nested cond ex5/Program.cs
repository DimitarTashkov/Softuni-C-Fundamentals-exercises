using System;

namespace Nested_cond_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            if(budget<10.00 && budget>5000.00)
            {
                Console.WriteLine("Invalid budget range");
            }
            string season = Console.ReadLine();
            if(season =="summer" ||season=="Summer" || season=="winter"||season=="Winter")
            if (budget <=100.00)
            {
                string place = "Bulgaria";
            switch (season)
                {
                    case "summer": Console.WriteLine("Camp = " + budget / 100*30 +" " + "in " +" "+place); break;
                    case "Summer": Console.WriteLine("Camp = " + budget / 100*30 + " " + "in " + " " + place); break;
                    case "winter": Console.WriteLine("Hotel = " + budget / 100*70 + " "+"in " + " "+ place); break;
                    case "Winter": Console.WriteLine("Hotel = " + budget / 100*70 + " " + "in " + " " + place); break;
                }
            }
            else if (budget<=1000.00)
                {
                    string place = "Balkans";
                 switch(season)
                    {
                        case "summer": Console.WriteLine("Camp = " + budget / 100 *40 + " " + "in the" + " " + place); break;
                        case "Summer": Console.WriteLine("Camp = " + budget / 100 *40+" " + "in the" + " " + place); break;
                        case "winter": Console.WriteLine("Hotel = " + budget / 100*80 + " " + "in the" + " " + place); break;
                        case "Winter": Console.WriteLine("Hotel = " + budget / 100*80 + " " + "in the" + " " + place); break;
                    }
                }
            else if (budget>1000.00 && budget<5000.00)
                {
                    string place = "Europe";
                    switch (season)
                    {
                        case "summer": Console.WriteLine("Camp = " + budget / 100 * 90 + " " + "in " + " " + place); break;
                        case "Summer": Console.WriteLine("Camp = " + budget / 100 * 90 + " " + "in " + " " + place); break;
                        case "winter": Console.WriteLine("Hotel = " + budget / 100 * 90 + " " + "in " + " " + place); break;
                        case "Winter": Console.WriteLine("Hotel = " + budget / 100 * 90 + " " + "in " + " " + place); break;
                    }

                }
        }
    }
}
