using System;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            double balance = 0.0;
            double productPrice = 0.0;
            while(input != "Start")
            {
                input = Console.ReadLine();
                if (input == "Start")
                {
                    break;
                }
                double coins = double.Parse(input);
                if(coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1.0 || coins == 2.0 )
                {
                    balance += coins;                  
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                
            }
            string product = " ";
            while(product != "End")
            {
                product = Console.ReadLine();
                if (product == "End")
                {
                    break;
                }
                else if (product == "Nuts")
                {
                    productPrice = 2.0;
                }
                else if (product == "Water")
                {
                    productPrice = 0.7;
                }
                else if (product == "Crisps")
                {
                    productPrice = 1.5;
                }
                else if (product == "Soda")
                {
                    productPrice = 0.8;
                }
                else if (product == "Coke")
                {
                    productPrice = 1.0;
                }
                else if(product != "Nuts" ||product!= "Water" || product != "Crisps" || product != "Soda" || product !="Coke")
                {
                    Console.WriteLine("Invalid product");
                    continue;
                }
                if (balance >= productPrice)
                {
                    balance -= productPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            
            Console.WriteLine($"Change: {balance:f2}");
        }
    }
}
