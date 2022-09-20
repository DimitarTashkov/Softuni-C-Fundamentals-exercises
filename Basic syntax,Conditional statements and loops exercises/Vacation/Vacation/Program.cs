using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double ticketPrice = 0;
            double totalPrice = 0;
            if(weekDay == "Friday")
            {
                if(groupType == "Students")
                {
                    ticketPrice = 8.45;
                    totalPrice = ticketPrice * peopleCount;
                }
                else if (groupType == "Business")
                {
                    ticketPrice = 10.90;
                    totalPrice = ticketPrice * peopleCount;

                }
                else if (groupType == "Regular")
                {
                    ticketPrice = 15;
                    totalPrice = ticketPrice * peopleCount;

                }
            }
            else if (weekDay == "Saturday")
            {
                if (groupType == "Students")
                {
                    ticketPrice = 9.80;
                    totalPrice = ticketPrice * peopleCount;
                }
                else if (groupType == "Business")
                {
                    ticketPrice = 15.60;
                    totalPrice = ticketPrice * peopleCount;

                }
                else if (groupType == "Regular")
                {
                    ticketPrice = 20;
                    totalPrice = ticketPrice * peopleCount;

                }

            }
            else if (weekDay == "Sunday")
            {
                if (groupType == "Students")
                {
                    ticketPrice = 10.46;
                    totalPrice = ticketPrice * peopleCount;
                }
                else if (groupType == "Business")
                {
                    ticketPrice = 16;
                    totalPrice = ticketPrice * peopleCount;

                }
                else if (groupType == "Regular")
                {
                    ticketPrice = 22.50;
                    totalPrice = ticketPrice * peopleCount;

                }

            }
            if(groupType == "Students" && peopleCount>=30)
            {
                totalPrice = totalPrice - totalPrice * 0.15;
            }
            else if (groupType == "Business" && peopleCount>=100)
            {
                totalPrice = totalPrice - 10 * ticketPrice;
            }
            else if (groupType == "Regular" && peopleCount >=10 && peopleCount <=20)
            {
                totalPrice = totalPrice - totalPrice * 0.05;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
