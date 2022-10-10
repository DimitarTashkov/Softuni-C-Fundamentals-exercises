using System;

namespace nz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before");
            int a = 5;
            int b = 10;
            int c = 0;
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            if (b>a)
            {
                c=b;
                b = a;
                Console.WriteLine("After");
                Console.WriteLine("a= "+c);
                Console.WriteLine("b= " + b);
            }
        }
    }
}
