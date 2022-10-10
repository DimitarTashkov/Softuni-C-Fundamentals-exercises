using System;

namespace exam_preparation_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int black = 0;
            int totalPoints = 0;
            int pointsPerBall = 0;
            int unmathced = 0;
            for(int i = 0;i<amount;i++)
            {
                string color = Console.ReadLine();
                switch(color)
                {
                    case "red":
                        red++;pointsPerBall = 5; totalPoints += pointsPerBall;
                        break;

                    case "orange":
                        orange++; pointsPerBall = 10; totalPoints += pointsPerBall;
                        break;

                    case "yellow":
                        yellow++; pointsPerBall = 15; totalPoints += pointsPerBall;
                        break;

                    case "white":
                        white++; pointsPerBall = 20; totalPoints += pointsPerBall;
                        break;

                    case "black":
                        black++; totalPoints /= 2;
                        break;

                    default:unmathced++;
                        break;
                }
             
            }
            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {unmathced}");
            Console.WriteLine($"Divides from black balls: {black}");
        }
    }
}
