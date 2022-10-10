using System;

namespace PB_d7_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorname = Console.ReadLine();
            double lastyearpoints = double.Parse(Console.ReadLine());

            int jurymembersnum = int.Parse(Console.ReadLine());

            double finalpoints = lastyearpoints;
            for(int i = 1; i <= jurymembersnum; i++)
            {
                string jurry = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                double totalmemberspoints = jurry.Length * points / 2;
                finalpoints += totalmemberspoints;
                if(finalpoints > 1250.5)
                {
                    break;
                }
                
                
            }
            if (finalpoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorname} got a nominee for leading role with {finalpoints}!");
            }
            else
            {
                double insufficent = 1250.5 - finalpoints;
                Console.WriteLine($"Sorry, {actorname} you need {insufficent} more!");
            }
        }
    }
}
