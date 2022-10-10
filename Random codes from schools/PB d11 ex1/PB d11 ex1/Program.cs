using System;

namespace PB_d11_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isbigger = false;
            for(int rows = 1; rows<= n;rows++)
            {
                for(int cols = 1;cols<=rows;cols++)
                {
                    if(current>n)
                    {
                        isbigger = true;
                            break;
                    }
                    Console.Write(current + " ");
                    current++;
                }
                if (isbigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
