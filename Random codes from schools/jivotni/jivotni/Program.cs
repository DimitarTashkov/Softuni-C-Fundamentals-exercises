using System;

namespace jivotni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an animal:");
            string animal;
            animal = Console.ReadLine();
            switch (animal)
            {
                case "bear": Console.WriteLine("mammal"); break;
                case "monkey": Console.WriteLine("mammal"); break;
                case "dolphin": Console.WriteLine("mammal"); break;
                case "snake": Console.WriteLine("Reptilia"); break;
                case "owl": Console.WriteLine("Aves"); break;
                default:
                    Console.WriteLine("Error"); break;
                    
            }
           
        }
    }
}
