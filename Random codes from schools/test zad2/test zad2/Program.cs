using System;

namespace test_zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            double terezaPocketMoney = double.Parse(Console.ReadLine());
            double moneyWon = double.Parse(Console.ReadLine());
            double razhodi = double.Parse(Console.ReadLine());
            double priceOfThePresent = double.Parse(Console.ReadLine());
            double savedMoneyThisWeek = 5 * terezaPocketMoney;
            double wonMoneyThisWeek = 5 * moneyWon;
            double moneySheHas = savedMoneyThisWeek + wonMoneyThisWeek-razhodi;
            if(moneySheHas>priceOfThePresent)
            {
                Console.WriteLine($"Profit: {moneySheHas:f2} BGN, the gift has been purchased.");
            }
            else
            {
                double insufficient = priceOfThePresent - moneySheHas;
                Console.WriteLine($"Insufficient money: {insufficient:f2} BGN.");
            }

        }
    }
}
