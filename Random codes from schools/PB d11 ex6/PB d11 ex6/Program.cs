using System;

namespace PB_d11_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            int students = 0;
            int kids = 0;
            int standart = 0;
            int totalTicketsForDay = 0;
           while(input != "Finish")
            {
                input = Console.ReadLine();
                if(input == "Finish")
                {
                    break;
                }
                string filmTitle = input;

                int seatsAvailable = int.Parse(Console.ReadLine());

                int currentSeats = seatsAvailable;

                string ticketType = "";
                int ticketsSoldForFilm = 0;

                while(ticketType != "End" && currentSeats > 0)
                {
                    ticketType = Console.ReadLine();
                    if(ticketType == "End")
                    {                      
                        break;
                    }
                   
                    ticketsSoldForFilm++;
                    totalTicketsForDay++;
                    currentSeats--;
                    switch(ticketType)
                    {
                        case "standard":
                            standart++;
                            break;
                        case "student":
                            students++;
                            break;
                        case "kid":kids++;
                            break;
                    }
                }
                double percentageFull = ticketsSoldForFilm / (seatsAvailable*1.0) *100;
                Console.WriteLine($"{filmTitle} - {percentageFull:f2}% full.");      
            }

            Console.WriteLine($"Total tickets: {totalTicketsForDay}");
            double percStudents = students / (totalTicketsForDay * 1.0) * 100;
            Console.WriteLine($"{percStudents:f2}% student tickets.");
            double percStandart = standart / (totalTicketsForDay * 1.0) * 100;
            Console.WriteLine($"{percStandart:f2}% standard tickets.");
            double percKids = kids / (totalTicketsForDay * 1.0) * 100;
            Console.WriteLine($"{percKids:f2}% kids tickets.");

        }
    }
}
