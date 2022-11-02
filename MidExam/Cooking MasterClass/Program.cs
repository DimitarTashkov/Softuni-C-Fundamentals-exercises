using System;

namespace Cooking_MasterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal packageOfFlour = decimal.Parse(Console.ReadLine());
            decimal singleEgg = decimal.Parse(Console.ReadLine());
            decimal singleApron = decimal.Parse(Console.ReadLine());
            int flourCount = students;
            int freeFlour = students/5;            
            decimal totalPrice = singleApron * (Math.Ceiling(students + students * 0.20m)) + singleEgg * 10 * students + packageOfFlour * (students - freeFlour);
            if(budget>=totalPrice)
            {
                Console.WriteLine($"Items purchased for {totalPrice:f2}$.");
            }
            else
            {
                Console.WriteLine($"{totalPrice-budget:f2}$ more needed.");
            }
        }
    }
}
