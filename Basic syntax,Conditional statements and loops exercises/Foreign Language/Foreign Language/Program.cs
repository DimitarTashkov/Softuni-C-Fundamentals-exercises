using System;

namespace Foreign_Language
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            switch (country)
            {
                case "Usa":
                case "England":
                    Console.WriteLine("English");
                    break;
                case "Mexico":
                case "Spain":
                case "Argentina":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
