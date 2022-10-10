using System;

namespace Fruit
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            if (s == "banana" || s == "appple" || s == "kiwi" || s == "cherry")
            {
                Console.WriteLine("fruit");
            }
            else if (s == "tomato" || s == "cucumber" || s == "pepper" || s == "carrot")
                Console.WriteLine("vegetable");
            else
                Console.WriteLine("unknown");
           
            
        }
    }
}
