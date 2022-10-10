using System;

namespace test_zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            int computers = int.Parse(Console.ReadLine());
            double actionsAccomplished = 0;
            double avgCount = 0;
            double allActions = 0;
            for(int i = 1;i<=computers;i++)
            {
                int rating = int.Parse(Console.ReadLine());
                double lastDigit = rating % 10;
                avgCount += lastDigit;
                int possibleActions = rating / 10;
                switch (lastDigit)
                {
                    case 2 :break;
                    case 3: actionsAccomplished = possibleActions * 0.5;
                         allActions += actionsAccomplished;
                        break;
                    case 4: actionsAccomplished = possibleActions * 0.7;
                        allActions += actionsAccomplished;
                        break;
                    case 5: actionsAccomplished = possibleActions * 0.85;
                        allActions += actionsAccomplished;
                        break;
                    case 6: actionsAccomplished = possibleActions;
                        allActions += actionsAccomplished;
                        break;
                }
                
            }
            Console.WriteLine($"{allActions:f2}");
            Console.WriteLine($"{avgCount / computers:f2}");
        }
    }
}
