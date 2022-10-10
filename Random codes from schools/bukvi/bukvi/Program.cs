using System;

namespace bukvi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведи буква:");
            char c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case 'а':
                case 'е':
                case 'о':
                    Console.WriteLine("широка гласна"); break;
                case 'и':
                case 'у':
                case 'ъ':
                    Console.WriteLine("тясна гласна"); break;
                case 'ю':
                case 'я':
                    Console.WriteLine("съставна  гласна"); break;
                case 'л':
                case 'м':
                case 'н':
                case 'р':
                    Console.WriteLine("сонорна  гласна"); break;
                case 'б':
                case 'в':
                case 'г':
                case 'д':
                case 'ж':
                case 'з':
                case 'ч':
                    Console.WriteLine("сонорна  гласна"); break;
                case 'п':
                case 'ф':
                case 'к':
                case 'т':
                case 'ш':
                case 'с':
                case 'х':
                case 'ц':
                    Console.WriteLine("сонорна  гласна"); break;
                case 'й':
                case 'ь':
                case 'щ':
                    Console.WriteLine("широка гласна"); break;
                default: if (c > 'A' && c < 'Z' || c > 'a' && c < 'z')
                    {
                        Console.WriteLine("Латинска буква");
                    }
                    else Console.Write("Знакът не е буква"); break;
                    Console.ReadKey(true);
            } 
        }
    }
}
