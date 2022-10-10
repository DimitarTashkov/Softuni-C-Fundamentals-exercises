using System;

namespace PB_d10_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            //Floorts go from last to first
            for(int fl = floors;fl >= 1;fl--)
            {
                //For each floor we go through all rooms in this floor
                for(int room = 0;room < rooms;room++)
                {
                    if(fl == floors)
                    {
                        //Last floor
                        Console.Write($"L{fl}{room} ");
                    }
                    else if(fl % 2== 0)
                    {
                        //even floor number
                        Console.Write($"O{fl}{room} ");
                    }
                    else if(fl %2 !=0)
                    {
                        //odd number floor
                        Console.Write($"A{fl}{room} ");
                    }
                }
                //after we go through all rooms on this floor we should go back
                //Go to the next line
                Console.WriteLine();


            }
        }
    }
}
