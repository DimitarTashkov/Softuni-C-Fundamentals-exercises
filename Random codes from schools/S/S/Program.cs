using System;

namespace S
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Circle radius. r = ");
            var r = double.Parse(Console.ReadLine());
            var area = Math.Round(Math.PI * r*r,3);
            var perimeter = Math.Round(2*Math.PI * r,3);
            Console.WriteLine("Area = " + area);
            Console.WriteLine("perimeter = " + perimeter);
        }
    }
}
