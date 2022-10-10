using System;

namespace PB_d7_ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentnums = int.Parse(Console.ReadLine());
            int initialpoints = int.Parse(Console.ReadLine());
            int thisyearspoint = 0;
            int winscounter = 0;
            for(int i = 1 ;i <=tournamentnums; i++)
            {
                string position = Console.ReadLine();
                switch(position)
                {
                    case "W":
                        thisyearspoint += 2000;
                        winscounter++;
                        break;
                    case "F":
                        thisyearspoint += 1200;
                        break;
                    case "SF":
                        thisyearspoint += 720;
                        break;
                }
            }
            int finalpoints = initialpoints + thisyearspoint;
            Console.WriteLine($"Final points: {finalpoints}");
            double avgpoints = Math.Floor(thisyearspoint / (tournamentnums*1.0));
            Console.WriteLine($"Average points: {avgpoints}");
            double percentagewins = (winscounter / (tournamentnums*1.0))*100;
            Console.WriteLine($"{percentagewins:f2}%");
        }
    }
}
