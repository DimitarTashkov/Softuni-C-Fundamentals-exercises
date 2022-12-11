using System;
using System.Text;
namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var sb = new StringBuilder();
            foreach (char currentChar in input)
            {
                int currentPosition = currentChar;
                currentPosition += 3;
                sb.Append((char)currentPosition);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
