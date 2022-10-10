using System;

namespace PB_d3_ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            string serie = Console.ReadLine();
            int episodeduretion = int.Parse(Console.ReadLine());
            int breakduretion = int.Parse(Console.ReadLine());

            double lunchtime = breakduretion / 8.0;
            double nothing = breakduretion / 4.0;
            double episodetime = breakduretion - lunchtime - nothing;
            if(episodetime>=episodeduretion)
            {
                double timeleft = episodetime - episodeduretion;
             Console.WriteLine($"You have enough time to watch {serie} and left with {Math.Ceiling(timeleft)} minutes free time.");
            }
            else
            {
                double neededtime = episodeduretion - episodetime;
                Console.WriteLine($"You don't have enough time to watch {serie}, you need {Math.Ceiling(neededtime)} more minutes.");
            }
        }
    }
}
