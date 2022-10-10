using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 5, players = 5;
            if (players  >= counter )
            {
              players = 10;
            }   
            if (players == counter)
            {
             counter++;
            }
            players = counter;
            Console.WriteLine(players);
        }
    }
}
