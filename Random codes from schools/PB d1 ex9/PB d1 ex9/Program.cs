using System;

namespace PB_d1_ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your measurements");
            int length = int.Parse(Console.ReadLine());
            int widthness = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double sizeincm = length * widthness * height;
            double sizeinl = sizeincm / 1000;
            double liters = sizeinl * (1 - (percentage/100));
            Console.WriteLine(liters);

        }
    }
}
