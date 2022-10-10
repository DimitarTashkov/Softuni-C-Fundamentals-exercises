using System;
using System.Linq;

namespace Reversed_array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bukvi = Console.ReadLine().Split(" ").ToArray();
            for (int i = bukvi.Length - 1; i >= 0; i--)
            {
                Console.Write(bukvi[i] + " ");
            }
        }
    }
}
