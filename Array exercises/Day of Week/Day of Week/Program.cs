using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {"Monday","Tuesday","Wednesday","Thursday","Friday","Saturday","Sunday" };
            int day = int.Parse(Console.ReadLine());
            if(day<1 || day>7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            else
            {
                Console.WriteLine(daysOfWeek[day - 1]);
            }
            
                 
        }
    }
}
