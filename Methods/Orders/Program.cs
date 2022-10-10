using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double result = GetOrders(product, quantity);
            Console.WriteLine("{0:f2}",result);
        }

        private static double GetOrders(string product, int quantity)
        {
            double result = 0;
            switch (product)
            {
                case "coffee":
                    result = quantity * 1.50;
                    break;
                case "water":
                    result = quantity*1;
                    break;
                case "coke":
                    result = quantity*1.40;
                    break;
                case "snacks":
                    result = quantity*2;
                    break;

            }
            return result;

        }
    }
}
