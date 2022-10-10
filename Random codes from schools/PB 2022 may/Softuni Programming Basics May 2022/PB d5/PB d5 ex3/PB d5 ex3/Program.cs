using System;

namespace PB_d5_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowertype = Console.ReadLine();
            int flowersnum = int.Parse(Console.ReadLine());
            int availablebudget = int.Parse(Console.ReadLine());
            double Totaltopay = 0;
            double discount = 0;
            if(flowertype == "Roses")
            {
                Totaltopay = flowersnum * 5;
                if(flowersnum>80)
                {
                 discount = 0.1 * Totaltopay;
                    Totaltopay -=discount;
                }
            }
            else if (flowertype == "Dahlias")
            {
                Totaltopay = flowersnum * 3.80;
                if (flowersnum>90)
                {
                    discount = 0.15 * Totaltopay;
                    Totaltopay -= discount;
                }
            }
            else if (flowertype == "Tulips")
            {
                Totaltopay = flowersnum * 2.80;
                if(flowersnum>80)
                {
                    discount = 0.15 * Totaltopay;
                    Totaltopay -= discount;
                }
            }
            else if (flowertype == "Narcissus")
            {
                Totaltopay = flowersnum * 3;
                if(flowersnum<120)
                {
                    discount = 0.15 * Totaltopay;
                    Totaltopay += discount;
                }
            }
            else if (flowertype == "Gladiolus")
            {
                Totaltopay = flowersnum * 2.50;
                if(flowersnum<80)
                {
                    discount = 0.2 * Totaltopay;
                    Totaltopay += discount;
                }

            }
            if(availablebudget>Totaltopay)
            {
                double change = availablebudget - Totaltopay;
                Console.WriteLine($"Hey, you have a great garden with {flowersnum} {flowertype} and {change:f2} leva left.");
            }
            else
            {
                double insufficient = Totaltopay - availablebudget;
                Console.WriteLine($"Not enough money, you need {insufficient:f2} leva more.");
            }

        }
    }
}
