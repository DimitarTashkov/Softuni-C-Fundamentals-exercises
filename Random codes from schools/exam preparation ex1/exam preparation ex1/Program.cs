using System;

namespace exam_preparation_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int series = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            double advertsTime = lenght * 0.2;
            double time = lenght + advertsTime;
            int extraTime = seasons * 10;
            double total = time * series * seasons + extraTime;
            Console.WriteLine($"Total time needed to watch the {name} series is {total} minutes.");
        }
    }
}
