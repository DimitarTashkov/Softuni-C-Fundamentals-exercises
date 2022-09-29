using System;

namespace Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());        
            double width = double.Parse(Console.ReadLine());         
            double height = double.Parse(Console.ReadLine());
           double V = (lenght * width * height)/3;
            Console.Write($"Length: Width: Height: Pyramid Volume: {V:f2}");
        }
    }
}
