using System;

namespace PB_d8_ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalgrades = 0;
            string name = Console.ReadLine();
            int currentclass = 1;
            int repeatcounter = 0;
            while(currentclass<=12)
            {
                double currentgrade = double.Parse(Console.ReadLine());
                totalgrades += currentgrade;
                //whenever grade is below 4, the class is repeteade
                if (currentgrade < 4)
                {
                    repeatcounter++;
                    if (repeatcounter > 1)
                    {
                        //we will get expeled
                        break;
                    }
                    continue;
                }
               
                currentclass++;
            }
            if(repeatcounter>1)
            {
                Console.WriteLine($"{name} has been excluded at {currentclass} grade");
            }
            else
            {
                double average = totalgrades / (currentclass-1 + repeatcounter);
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
        }
    }
}
