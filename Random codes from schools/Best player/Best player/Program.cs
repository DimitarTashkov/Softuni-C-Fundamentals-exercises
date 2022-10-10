using System;

namespace Best_player
{
    class Program
    {
        static void Main(string[] args)
        {
            string playername = string.Empty;

            int maxPoint = int.MinValue;
            while(true)
            {
                string line = Console.ReadLine();
                if(line == "END")
                {
                    if (maxPoint >= 3 && maxPoint<10)
                    {
                        Console.WriteLine($"{playername} is the best player!");
                        Console.WriteLine($"He has scored {maxPoint} goals and made a hat-trick !!!");
                        break;
                    }
                    else if (maxPoint >= 10)
                    {
                        Console.WriteLine($"{playername} is the best player!");
                        Console.WriteLine($"He has scored {maxPoint} goals and made a hat-trick !!!");
                        break;
                    }
                    else if (maxPoint < 3)
                    {
                        Console.WriteLine($"{playername} is the best player!");
                        Console.WriteLine($"He has scored {maxPoint} goals.");
                        break;
                    }
                }
                else
                {
                    int goals = int.Parse(Console.ReadLine());
                    if(goals>maxPoint)
                    {
                        maxPoint = goals;
                        playername = line;
                         if (maxPoint >= 10)
                        {
                            Console.WriteLine($"{playername} is the best player!");
                            Console.WriteLine($"He has scored {maxPoint} goals and made a hat-trick !!!");
                            break;
                        }
                    }
                }
                 
               
            }

        }
    }
}
