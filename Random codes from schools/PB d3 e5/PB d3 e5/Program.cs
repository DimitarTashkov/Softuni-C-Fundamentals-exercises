using System;

namespace PB_d3_e5
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmbudget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double priceforstatist = double.Parse(Console.ReadLine());
            double filmdecor = filmbudget * 0.1;
            double clothesSum = statist * priceforstatist;
            double totalforeverything = filmdecor + clothesSum;
            if(statist>150)
            {
                clothesSum = clothesSum - clothesSum * 0.1;
                totalforeverything = clothesSum + filmdecor;
                if (totalforeverything > filmbudget)
                {
                    double insufficient = totalforeverything - filmbudget;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {insufficient:f2} leva more.");

                }
                else
                {
                    double change = filmbudget - totalforeverything;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {change:f2} leva left.");
                }
            }
            else
            {
                if (totalforeverything > filmbudget)
                {
                    double insufficient = totalforeverything - filmbudget;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {insufficient:f2} leva more.");

                }
                else
                {
                    double change = filmbudget - totalforeverything;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {change:f2} leva left.");
                }
            }
            
        }
    }
}
