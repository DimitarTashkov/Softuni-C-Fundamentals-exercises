using System;

namespace exam_preparation_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int kozunakNum = int.Parse(Console.ReadLine());
            string bestBaker = "";
            int maxpoints = 0;
            for(int i = 1;i<=kozunakNum;i++)
            {
                 string bakerName = Console.ReadLine();
                int points = 0;

                string input = Console.ReadLine();
                while (input != "Stop")
                {
                    
                    points += int.Parse(input);
                    input = Console.ReadLine();
                }
                Console.WriteLine($"{bakerName} has {points} points.");
                if (points > maxpoints)
                {
                    Console.WriteLine($"{bakerName} is the new number 1!");
                    maxpoints = points;
                    bestBaker = bakerName;
                }
            }
            Console.WriteLine($"{bestBaker} won  competition with {maxpoints} points!");
        }
    }
}
