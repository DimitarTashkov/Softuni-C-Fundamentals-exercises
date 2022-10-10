using System;

namespace Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = Area(width, height);
            Console.WriteLine(area);
        }

        private static double Area(double width, double height)
        {
            double area = 0;
            area = width * height;
            return area;
        }
    }
}
