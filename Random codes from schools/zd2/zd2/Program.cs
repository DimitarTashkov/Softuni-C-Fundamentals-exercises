using System;

namespace zd2
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
           float h = float.Parse(Console.ReadLine());
            float m = h * 60;
            float s = m * 60;
            float ms = 1000/(v*s);
            float kmh = 1000/(v*h);
           float mh =  1609/(v * h) ;

            Console.WriteLine("Meters per second {0}, Kilometers per hour {1}, Miles per hour {2}", ms, kmh, mh);
        }
    }
}
