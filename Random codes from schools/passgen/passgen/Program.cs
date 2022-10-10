using System;

namespace passgen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for(int ch1 = 1;ch1<=n;ch1++)
            {
                for (int ch2 = 1; ch2 <= n; ch2++)
                {
                    for (int ch3 = 1;ch3<=l; ch3++)
                    {
                        for (int ch4 = 1; ch4 <= l; ch4++)
                        {
                            for(int ch5 = Math.Max(ch1,ch2)+1;ch5<=n;ch5++)
                            {
                                Console.Write($"{ch1}{ch2}{(char)(97+ch3)}{(char)(97+ch4)}{ch5} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
