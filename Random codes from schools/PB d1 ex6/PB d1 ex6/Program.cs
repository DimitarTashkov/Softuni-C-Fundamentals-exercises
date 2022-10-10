using System;

namespace PB_d1_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the required amount");
            int quantityn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the required amount");
            int quantityb = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the required amount");
            int quantityrb = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the time");
            int time = int.Parse(Console.ReadLine());
            double nailon = (quantityn + 2) * 1.50;
            double boq = (quantityb + quantityb*0.1) * 14.50;
            double razreditel = quantityrb * 5.00;
            double torbichka = 0.40;
            double price = (nailon + boq + razreditel + torbichka);
            double workersprice = ( price*0.3) * time;
            double totalprice = price + workersprice;
            Console.WriteLine(totalprice);
        }
    }
}
