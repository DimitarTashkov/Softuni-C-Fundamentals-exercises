using System;
using System.Linq;

namespace zadac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of numbers");
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];
            for(int i = 0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
