using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            int caloriesCount = 0;
            string pattern = @"(\||\#)(?<itemName>[A-Za-z]+\s?[A-Z-a-z]+)(\1)(?<expirationDate>(?<day>\d{2})\/(?<month>\d{2})\/(?<year>\d{2}))(\1)(?<calories>\d{1,5})(\1)";
            string text = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                int calories = int.Parse(match.Groups["calories"].Value);
                caloriesCount += calories;               
            }
            int daysCount = caloriesCount / 2000;
            Console.WriteLine($"You have food to last you for: {daysCount} days!");
            foreach (Match match in matches)
            {
                string itemName = match.Groups["itemName"].Value;
                string expirationDate = match.Groups["expirationDate"].Value;
                int calories = int.Parse(match.Groups["calories"].Value);
                Console.WriteLine($"Item: {itemName}, Best before: {expirationDate}, Nutrition: {calories}");
            }
        }
    }
}
