using System;

namespace test_zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int changesCount = 0;
            bool StopTheCycle = false;
            for (int i = k; i <= 9; i++)
            {
                for (int j = 9; j >= l; j--)
                {
                    for (int f = m; f <= 8; f++)
                    {
                        for (int t = 9; t >= n; t--)
                        {
                           bool validNumber = i % 2 == 0 &&
                           f % 2 == 0 &&
                           j % 2 != 0 &&
                           t % 2 != 0;
                           int firstNumber = i * 10 + j;
                           int secondNumber = f * 10 + t;                           
                           if (validNumber && firstNumber == secondNumber)
                              {
                                 Console.WriteLine("Cannot change the same player.");
                              }
                           else if (validNumber && firstNumber != secondNumber)
                              {
                                  Console.WriteLine($"{i}{j} - {f}{t}");
                                   changesCount++;
                                   if (changesCount >= 6)
                                      {
                                         StopTheCycle = true;
                                      }
                              }
                            if (StopTheCycle)
                            {
                                break;
                            }

                        }
                            if (StopTheCycle)
                            {
                                break;
                            }
                        }
                        if (StopTheCycle)
                        {
                            break;
                        }
                    }
                    if (StopTheCycle)
                    {
                        break;
                    }
                }            
            }             
        }
    }