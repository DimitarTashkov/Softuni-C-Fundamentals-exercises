using System;

namespace PB_d7_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilysage = int.Parse(Console.ReadLine());
           double washingmachine = double.Parse(Console.ReadLine());
            int toysingleprice = int.Parse(Console.ReadLine());
            
            double piggybank = 0;
            double cashgive = 10;
            int toysnum = 0;
            for(int  birthdate = 1;birthdate<=lilysage;birthdate++)
            {
              if(birthdate %2 ==0)
                {
                    piggybank += cashgive;
                    piggybank--;
                    cashgive += 10;
                }
              else
                {
                    toysnum++;
                }
            }
            int totalfromtoys = toysnum * toysingleprice;
            double totalformachine = totalfromtoys + piggybank;
            if(totalformachine>=washingmachine)
            {
                Console.WriteLine($"Yes!{totalformachine-washingmachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingmachine-totalformachine:f2}");
            }
        }
    }
}
