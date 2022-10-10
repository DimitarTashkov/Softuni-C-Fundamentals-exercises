using System;

namespace PB_d1_ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the annual price for basketball");
            double annualprice = int.Parse(Console.ReadLine());
            double kecove = annualprice-annualprice/100 * 40;
            double ekip = kecove - kecove / 100 * 20;
            double ball = ekip / 4;
            double accesories = ball / 5;
            double totalprice = annualprice+kecove + ekip + ball + accesories;
            Console.WriteLine(totalprice);


        }
    }
}
