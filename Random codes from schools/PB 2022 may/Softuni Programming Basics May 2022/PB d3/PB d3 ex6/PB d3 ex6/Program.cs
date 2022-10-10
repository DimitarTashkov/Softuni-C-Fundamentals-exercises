using System;

namespace PB_d3_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordtime = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timespermeters = double.Parse(Console.ReadLine());

            double timefordistance = timespermeters * distance;

            double timesdelayed = Math.Floor(distance / 15);

            double delaytime = timesdelayed * 12.5;

            double totaltime = timefordistance + delaytime;

            bool recordisbeaten = recordtime > totaltime;

            if(recordisbeaten)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totaltime:F2} seconds.");
            }
            else 
            {
                Console.WriteLine($"No, he failed! He was {totaltime-recordtime:F2} seconds slower.");

            }
        }
    }
}
