using System;

namespace exam_preparation_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            int secondsFor100m = int.Parse(Console.ReadLine());
            int controlTime = minutes * 60 + seconds;
            double reducedSeconds = lenght / 120 * 2.5;
            double martinTime = lenght / 100 * secondsFor100m - reducedSeconds;
            if(controlTime>=martinTime)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {martinTime:f3}.");
            }
            else
            {
                double insufficient = martinTime - controlTime;
                Console.WriteLine($"No, Marin failed! He was {insufficient:f3} second slower.");

            }
        }
    }
}
