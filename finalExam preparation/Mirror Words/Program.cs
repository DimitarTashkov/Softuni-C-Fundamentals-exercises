using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][A-za-z0-9]{4,}[A-Z]@#+";
            int n = int.Parse(Console.ReadLine());

            Regex barcode = new Regex(pattern);
            Regex productRegex = new Regex(@"\d+");
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = barcode.Match(input);
                if(match.Success)
                {
                    MatchCollection productGroupMatch = productRegex.Matches(match.Value);
                    if(productGroupMatch.Count > 0)
                    {
                        Console.WriteLine($"Product group: {string.Join("",productGroupMatch)}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
                  


            }
        }
    }
}
