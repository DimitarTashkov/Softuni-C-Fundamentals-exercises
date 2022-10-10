using System;

namespace PB_d1_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko paketa himikali iskash ?");
            int amounth = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolko paketa markeri iskash ?");
            int amountm = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolko litra preparat iskash ?");
            int amount = int.Parse(Console.ReadLine());
            Console.WriteLine("izberi si otstupka ?");
            double discount = double.Parse(Console.ReadLine());
            double himikali = amounth * 5.80;
            double markeri = amountm * 7.20;
            double preparat = amount * 1.20;
            double cena = (himikali + markeri + preparat)-((himikali+markeri+preparat)*discount/100);
            Console.WriteLine(cena);

           

        }
    }
}
