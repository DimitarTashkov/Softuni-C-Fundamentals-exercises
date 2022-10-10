using System;

namespace test_zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = 0;
            int startPoint = 5364;
            int endPoint = 8848;
            while (true)
            {
               
                string answer = Console.ReadLine();
                if(answer == "Yes")
                {
                    days++;                 
                    int meters = int.Parse(Console.ReadLine());
                    if (days >= 5)
                    {
                        Console.WriteLine($"Failed!");
                        Console.WriteLine($"{startPoint}");
                        break;
                    }
                    startPoint += meters;
                }
                else if (answer== "No")
                {
                    int meters = int.Parse(Console.ReadLine());
                    startPoint += meters;
                }
                if(answer == "END")
                {
                    Console.WriteLine($"Failed!");
                    Console.WriteLine($"{startPoint}");
                    break;
                } 
                if(startPoint>=endPoint)
                {
                    break;
                }
            }

            if (startPoint >= endPoint)
            {
                Console.WriteLine($"Goal reached for {days+1} days!");
            }
           
        }
    }
}
