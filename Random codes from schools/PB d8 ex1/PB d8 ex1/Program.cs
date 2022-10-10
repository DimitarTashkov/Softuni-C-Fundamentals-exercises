using System;

namespace PB_d8_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(command);
            }
        }
    }
}
