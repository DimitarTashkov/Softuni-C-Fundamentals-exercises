using System;

namespace PB_d3_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int totaltime = firstTime + secondTime + thirdTime;
            int minutes = totaltime / 60;
            int seconds = totaltime % 60;
            if(seconds<10)
            {
                Console.WriteLine($"{minutes}:{seconds:d2}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
