using System;

namespace PB_d9_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
          int lenght = int.Parse(Console.ReadLine());
          int width = int.Parse(Console.ReadLine());
          int sum = lenght * width;
            while(sum>0)
            {
                string input = Console.ReadLine();
              if(input == "STOP")
                {
                    break;
                }
                sum -= int.Parse(input);
            }
            if(sum>=0)
            {
                Console.WriteLine($"{sum} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(sum)} pieces more.");
            }
        }
    }
}
