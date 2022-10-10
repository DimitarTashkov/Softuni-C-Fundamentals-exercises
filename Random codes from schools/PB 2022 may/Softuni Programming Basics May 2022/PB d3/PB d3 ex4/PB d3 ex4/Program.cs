using System;

namespace PB_d3_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine());
            int puzzlesnum = int.Parse(Console.ReadLine());
            int dollsnum = int.Parse(Console.ReadLine());
            int teddybearsnum = int.Parse(Console.ReadLine());
            int minionsnum = int.Parse(Console.ReadLine());
            int trucksnum = int.Parse(Console.ReadLine());
            int broika = puzzlesnum + dollsnum + teddybearsnum + minionsnum + trucksnum;
            double puzzlesprice = puzzlesnum * 2.60;
            double dollsprice = dollsnum * 3.00;
            double teddybearsprice = teddybearsnum* 4.10;
            double minionsprice = minionsnum * 8.20;
            double trucksprice = trucksnum * 2.00;
            double totalwithoutdiscount = puzzlesprice + dollsprice + teddybearsprice + minionsprice + trucksprice; 
            double total;
            if(broika>=50)
            {
                total = totalwithoutdiscount-(totalwithoutdiscount*0.25);
                total = total-total*0.1;
                if (total > price)
                {
                    double change = total - price;
                    Console.WriteLine($"Yes! {change:f2} lv left.");
                }
                else 
                {
                    double insufficient = price - total;
                    Console.WriteLine($"Not enough money! {insufficient:f2} lv needed.");
                }
            }
            else
            {
                totalwithoutdiscount = totalwithoutdiscount - totalwithoutdiscount * 0.1;
                if (totalwithoutdiscount > price)
                {
                    
                    double change = totalwithoutdiscount - price;
                    Console.WriteLine($"Yes! {change:f2} lv left.");
                }
                else
                {
                    double insufficient = price - totalwithoutdiscount;
                    Console.WriteLine($"Not enough money! {insufficient:f2} lv needed.");
                }
            }
        }
    }
}
