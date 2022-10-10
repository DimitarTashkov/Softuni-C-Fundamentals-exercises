using System;

namespace PB_d3_e3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int fifteenminutes = 15;
            minutes = minutes + fifteenminutes; 
            if(minutes > 59)
            {
                hours = hours + 1;
                if (hours>23)
                {
                    hours = 0;
                }

                minutes = minutes - 60;
              
            }
            Console.WriteLine($"{hours}:{minutes:D2}");

        }
    }
}
