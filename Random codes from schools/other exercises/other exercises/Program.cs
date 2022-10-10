using System;
using System.Linq;

namespace other_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] chisla = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            if (n==1)
            {
                for(int b =0;b<chisla.Length/2;b++)
         
                    Console.WriteLine(chisla[3]);
            }   
            if ()
            {              
                   int nah = n / 2 - 1;
                   int nahh = n / 2;
                Console.WriteLine($"First{chisla[nah]},second{chisla[nahh]}");
                  
            }
         
          

        }
    }
}
