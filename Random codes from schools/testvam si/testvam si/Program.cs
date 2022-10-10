using System;
using System.Linq;
using System.Collections.Generic;

namespace testvam_si
{
    class Program
    {
        static void Main(string[] args)
        {
            int otgovor; int reversed = 0;
            List<int> chisla = new List<int>();
            chisla.Add(123); 
            chisla.Add(567);
            chisla.Add(923);
            chisla.Reverse(0,3);
            foreach (int chislo in chisla)
            {
             while (chislo!=0)
                {
                    otgovor = chislo % 10;
                    int chislo3 = chislo / 10;
                    reversed = (reversed * 10) + otgovor;
                }
                Console.WriteLine("Reversed number is: {0}", reversed);
            }

        }
    }


}
