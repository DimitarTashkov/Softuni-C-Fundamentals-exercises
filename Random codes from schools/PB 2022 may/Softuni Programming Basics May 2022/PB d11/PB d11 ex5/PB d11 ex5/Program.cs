using System;

namespace PB_d11_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                int iTwin = i;
                bool isSpecial = true;
                for(int j = 1; j <= 4;j ++)
                {
                    int lastDigit = iTwin % 10;
                    if(lastDigit == 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    int remainder = n % lastDigit;
                    if(remainder != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                    iTwin /= 10;
                }
                if(isSpecial)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
