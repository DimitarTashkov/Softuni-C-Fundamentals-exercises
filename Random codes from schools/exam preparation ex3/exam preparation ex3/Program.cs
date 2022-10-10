using System;

namespace exam_preparation_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            string color = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            int price = 0;
            double totalPrice = 0;
            if(size == "Large")
            {
                if(color=="Red")
                {
                    price = 16;
                    totalPrice = amount * price;

                }
                else if(color == "Green")
                {
                    price = 12;
                    totalPrice = amount * price;
                }
                else if (color == "Yellow")
                {
                    price = 9;
                    totalPrice = amount * price;
                }
            }
            else if (size == "Medium")
            {
                if (color == "Red")
                {
                    price = 13;
                    totalPrice = amount * price;

                }
                else if (color == "Green")
                {
                    price = 9;
                    totalPrice = amount * price;
                }
                else if (color == "Yellow")
                {
                    price = 7;
                    totalPrice = amount * price;
                }
            }
            else if (size == "Small")
            {
                if (color == "Red")
                {
                    price = 9;
                    totalPrice = amount * price;

                }
                else if (color == "Green")
                {
                    price = 8;
                    totalPrice = amount * price;
                }
                else if (color == "Yellow")
                {
                    price = 5;
                    totalPrice = amount * price;
                }
            }
            double fullPrice = totalPrice - totalPrice * 0.35;
            Console.WriteLine($"{fullPrice:f2} leva.");
        }
    }
}
