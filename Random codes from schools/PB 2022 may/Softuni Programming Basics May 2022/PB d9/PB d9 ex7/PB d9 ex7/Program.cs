using System;

namespace PB_d9_ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int roomvolume = width * height * length;
            while(roomvolume > 0)
            {
                string input = Console.ReadLine();
                if(input == "Done")
                {
                    break;
                }
                roomvolume -= int.Parse(input);
            }
            if(roomvolume > 0)
            {
                Console.WriteLine($"{roomvolume} Cubic meters left.");
            }
            else
            {
                int absolutevollume = Math.Abs(roomvolume);
                Console.WriteLine($"No more free space! You need {absolutevollume} Cubic meters more.");

            }
        }
    }
}
