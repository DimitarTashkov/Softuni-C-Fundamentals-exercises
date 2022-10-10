using System;

namespace PB_d9_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalsteps = 0;
            while (totalsteps < 10000)
            {
                string input = Console.ReadLine();
                if (input == "Going home")
                {
                    totalsteps += int.Parse(Console.ReadLine());
                    break;
                    

                }
                int steps = int.Parse(input);
                totalsteps += steps;

            }
            if (totalsteps >= 10000)
            {
                int moresteps = totalsteps - 10000;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{moresteps} steps over the goal!");
            }
            else
            {
                int lesssteps = 10000 - totalsteps;
                Console.WriteLine($"{lesssteps} more steps to reach goal.");
            }
        }
    }
}
