using System;

namespace exam_preparation_ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKg = int.Parse(Console.ReadLine());
            int foodInG = foodInKg * 1000;
            int totalFood = 0;
            int foodHeEats = 0;
            while (true)
            {
                string stop = Console.ReadLine();
                if(stop == "Adopted")
                {
                    break;
                }
                 foodHeEats = int.Parse(stop);
                totalFood += foodHeEats;

            }
            if(foodInG>=totalFood)
            {
                int foodLeft = foodInG - totalFood;
                Console.WriteLine($"Food is enough! Leftovers: {foodLeft} grams.");
            }
            else
            {
                int foodNeeded = totalFood - foodInG;
                Console.WriteLine($"Food is not enough. You need {foodNeeded} grams more.");
            }
            
        }
    }
}
