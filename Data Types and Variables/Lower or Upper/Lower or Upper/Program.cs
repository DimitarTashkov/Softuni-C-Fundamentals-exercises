using System;

namespace Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());
            string bukva = character.ToString();
            if(bukva == bukva.ToUpper())
            {
                Console.WriteLine("upper-case");
            }
            else if (bukva == bukva.ToLower())
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
