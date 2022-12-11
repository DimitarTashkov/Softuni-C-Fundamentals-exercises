using System;
using System.Linq;
using System.Collections.Generic;

namespace Orders
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            string input;
            while ((input = Console.ReadLine())!= "buy")
            {

                string[] inputInfo = input.Split(" ");

                string productType = inputInfo[0];
                decimal price = decimal.Parse(inputInfo[1]);
                int quantity = int.Parse(inputInfo[2]);

                if (!products.Any(x => x.Name == productType))
                {
                    products.Add(new Product(productType, price, quantity));
                }
                else
                {
                    Product currentProduct = products.FirstOrDefault(x => x.Name == productType);

                    currentProduct.Quantity += quantity;
                    currentProduct.Price = price;
                }
            }

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} -> {product.GetTotalPrice():f2}");
            }
        }
    }

    public class Product
    {
        public Product(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }


        public decimal GetTotalPrice()
        {
            return this.Price * this.Quantity;
        }
    }

}
