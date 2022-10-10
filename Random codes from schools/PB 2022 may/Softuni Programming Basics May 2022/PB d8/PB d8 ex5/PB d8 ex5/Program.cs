using System;

namespace PB_d8_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            double sum = 0;
            while ((command = Console.ReadLine())!= "NoMoreMoney")
            {
                double money = double.Parse(command);
                if(money<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                sum += money;
                Console.WriteLine($"Increase: {money:f2}");
            }
            Console.WriteLine($"Total: {sum:f2}");
        }
    }
}
