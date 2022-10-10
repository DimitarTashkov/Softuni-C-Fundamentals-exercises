using System;

namespace test_zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfHartiq = int.Parse(Console.ReadLine());
            int amountOfPlat = int.Parse(Console.ReadLine());
            double amountOfLepilo = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double hartiqCena = amountOfHartiq * 5.80;
            double platCena = amountOfPlat * 7.20;
            double lepiloCena = amountOfLepilo * 1.20;
            double totalPrice = hartiqCena + platCena + lepiloCena;
            double priceWithDiscount = totalPrice - totalPrice / 100 * discount;
            Console.WriteLine($"{priceWithDiscount:f3}");

        }
    }
}
