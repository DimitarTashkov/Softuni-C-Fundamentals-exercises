using System;

namespace PB_d5_ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int examhour = int.Parse(Console.ReadLine());//9
            int examminutes = int.Parse(Console.ReadLine());//40

            int arrivehour = int.Parse(Console.ReadLine());//10
            int arriveminutes = int.Parse(Console.ReadLine());//40

            int examstartinmunites = examhour * 60 + 40;//580

            int arriveinminutes = arrivehour * 60 + arriveminutes;//640

            int differenceminutes = examstartinmunites - arriveinminutes;
            if(differenceminutes>=0 &&differenceminutes<=30)
            {
                //on time
            }
            else if(differenceminutes>30)
            {
                //early
            }
            else if(differenceminutes<0)
            {
                //late
            }
        }
    }
}
