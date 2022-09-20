using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());

            int students = int.Parse(Console.ReadLine());

            double lightsaberPrice = double.Parse(Console.ReadLine());

            double robesPrice = double.Parse(Console.ReadLine());

            double bellPrice = double.Parse(Console.ReadLine());
          
            double sabres= Math.Ceiling(students + students * 0.10);

            double freeBelts = 0;

            double bellsFinalprice = bellPrice * students;
            if (students>=6)
            {
                freeBelts = students / 6;
                bellsFinalprice -= freeBelts * bellPrice;
            }
            double sabresFinalPrice = sabres * lightsaberPrice;
            double robesFinalPrice = robesPrice * students;
            double TotalPrice = sabresFinalPrice + robesFinalPrice + bellsFinalprice;

            if (money>=TotalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {TotalPrice:f2}lv. ");
            }
            else
            {
                double insufficient = TotalPrice - money;
                Console.WriteLine($"John will need {insufficient:f2}lv more.");
            }
        }
    }
}
