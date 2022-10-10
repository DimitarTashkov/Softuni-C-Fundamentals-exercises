using System;

namespace PB_d2_ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a figure");
            string figure = Console.ReadLine();
            double area = 0;
            if(figure == "square")
            {
                double first = double.Parse(Console.ReadLine());
                area = first*first;
            }
            else if (figure == "rectangle")
            {
                double first = double.Parse(Console.ReadLine());
                double second = double.Parse(Console.ReadLine());
                area = first * second;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if (figure == "triangle")
            {
                double c = double.Parse(Console.ReadLine());
                double hc = double.Parse(Console.ReadLine());
                area = (c * hc) / 2;
            }
            Console.WriteLine($"{area:F3}");
        }   
    }
}
