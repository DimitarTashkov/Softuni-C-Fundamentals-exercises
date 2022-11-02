using System;
using System.Linq;
using System.Collections.Generic;

namespace Append_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> arrays = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries).Reverse().ToList();
            List<int> numbers = new List<int>();

            foreach (string str in arrays)
            {
                numbers.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
