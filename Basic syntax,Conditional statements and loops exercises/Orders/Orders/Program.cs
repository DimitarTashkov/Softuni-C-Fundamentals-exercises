using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double pricePerCapsule = 0.0;
            int days = 0;
            int capsules = 0;
            double orderPrice = 0.0;
            double total = 0;
            for(int i = 1;i<=n;i++)
            {
                pricePerCapsule = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsules = int.Parse(Console.ReadLine());
                orderPrice = ((days * capsules) * pricePerCapsule);
                total += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
