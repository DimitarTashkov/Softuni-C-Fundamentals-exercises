using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] passengerPerWagon = new int[n];
            int sum = 0;
            for (int i = 0; i <= passengerPerWagon.Length-1;i++)
            {
                int passengers = int.Parse(Console.ReadLine());
                passengerPerWagon[i] = passengers;
                sum += passengerPerWagon[i];
            }
            foreach(int amount in passengerPerWagon)
            {
                Console.Write(amount+" ");               
            }
            Console.WriteLine("");
            Console.WriteLine(String.Join(" ",sum));
        }
    }
}
