using System;

namespace PB_d10_ex5
{
    class Program
    {
        static void Main(string[] args)
        {            
                string destination = "";
                while(destination != "End")
                {
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }
                double requiredBudget = double.Parse(Console.ReadLine());
                double savings = 0;
                while (savings < requiredBudget)
                {
                    double investment = double.Parse(Console.ReadLine());

                    savings += investment;
                }
                Console.WriteLine($"Going to {destination}!");
                }             
        }
    }
}
