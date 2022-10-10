using System;

namespace PB_d7_ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupnums = int.Parse(Console.ReadLine());
            int goingtomusala = 0;
            int goingtoMontblanc = 0;
            int goingtokilimandjaro = 0;
            int goingtok2 = 0;
            int goingtoeverest = 0;
            int allpeople = 0;
            for ( int i = 1;i<=groupnums;i++)
            {
                int peopleingroupnum = int.Parse(Console.ReadLine());
                allpeople += peopleingroupnum;
                if(peopleingroupnum>= 1 && peopleingroupnum<= 5)
                {
                    goingtomusala += peopleingroupnum;
                }
                else if (peopleingroupnum>= 6 && peopleingroupnum<= 12)
                {
                    goingtoMontblanc += peopleingroupnum;
                }
                else if(peopleingroupnum>= 13 && peopleingroupnum<= 25)
                {
                    goingtokilimandjaro += peopleingroupnum;
                }
                else if(peopleingroupnum>= 26 && peopleingroupnum<= 40)
                {
                    goingtok2 += peopleingroupnum;
                }
                else if (peopleingroupnum>= 41)
                {
                    goingtoeverest += peopleingroupnum;
                }
            }
            double percentagemusala = goingtomusala / (allpeople*1.0)*100;
            double percentamontblanc = goingtoMontblanc / (allpeople * 1.0)*100;
            double percentagekillimandjaro =goingtokilimandjaro / (allpeople * 1.0)*100;
            double percentageK2 = goingtok2 / (allpeople * 1.0)*100;
            double percentageeverest = goingtoeverest / (allpeople * 1.0)*100;
            Console.WriteLine($"{percentagemusala:f2}%");
            Console.WriteLine($"{percentamontblanc:f2}%");
            Console.WriteLine($"{percentagekillimandjaro:f2}%");
            Console.WriteLine($"{percentageK2:f2}%");
            Console.WriteLine($"{percentageeverest:f2}%");
        }
    }
}
