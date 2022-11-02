using System;
using System.Linq;
using System.Collections.Generic;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = new List<string>();    
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArguments = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = cmdArguments[0];
                if(cmdArguments.Length == 3)
                {
                    //is going
                    if(guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }
                    guestList.Add(name);
                }
                else if(cmdArguments.Length == 4)
                {
                    //is not going
                    if(!guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }
                    guestList.Remove(name);
                }
            }
            PrintGuestList(guestList);
            

        }
        static void PrintGuestList(List<string> questList)
        {
            //change here will be appended in the Main()
            foreach(string name in questList)
            {
                Console.WriteLine(name);
            }
        }
    }
}
