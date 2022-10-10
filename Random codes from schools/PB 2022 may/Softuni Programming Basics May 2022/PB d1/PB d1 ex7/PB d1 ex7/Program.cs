using System;

namespace PB_d1_ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the amount");
            int pileshkoquantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the amount");
            int ribaquantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the amount");
            int vegeterianquantity = int.Parse(Console.ReadLine());
            double pileshko = pileshkoquantity * 10.35;
            double riba = ribaquantity * 12.40;
            double vegeterian = vegeterianquantity* 8.15;
            double suma = pileshko + riba + vegeterian;
            double desertprice = suma/100*20;
            double delivery = 2.50;
            double fullprice = suma + desertprice + delivery;
            Console.WriteLine(fullprice);

        }
    }
}
