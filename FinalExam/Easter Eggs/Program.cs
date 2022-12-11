using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\@|\#)+(?<color>[a-z]{3,})(\@|\#)+(\D|\W)*\/+(?<amount>\d+)\/+";
            string readInformation = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(readInformation);
            foreach (Match item in matches)
            {
                string color = item.Groups["color"].Value;
                int amount = int.Parse(item.Groups["amount"].Value);
                Console.WriteLine($"You found {amount} {color} eggs!");
            }
        }
    }
}
