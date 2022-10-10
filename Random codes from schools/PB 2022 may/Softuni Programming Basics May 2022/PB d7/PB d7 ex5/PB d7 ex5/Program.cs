using System;

namespace PB_d7_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opentabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for(int i = 1;i<=opentabs;i++)
            {
                string websitenames = Console.ReadLine();
                switch(websitenames)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 90;
                        break;
                }
                if(salary<=0)
                {
                    break;
                }
            }
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine($" {salary}");
            }

        }
    }
}
