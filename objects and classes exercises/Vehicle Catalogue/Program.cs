using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Vehicle> catalogue = new List<Vehicle>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commands = command.Split(" ");
                string typeOfVehicle = commands[0];
                string model = commands[1];
                string color = commands[2];
                int horsePowers = int.Parse(commands[3]);
                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsePowers);
                catalogue.Add(vehicle);
            }
            while (true)
            {
                string model = Console.ReadLine();
                if (model == "Close the Catalogue")
                {
                    break;
                }
                Console.WriteLine(catalogue.Find(x => x.Model == model));

            }
            var onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            var onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();
            double totalCarsHorsepower = 0;
            double totalTrucksHorsepower = 0;

            foreach (var car in onlyCars)
            {
                totalCarsHorsepower += car.HorsePower;
            }

            foreach (var truck in onlyTrucks)
            {
                totalTrucksHorsepower += truck.HorsePower;
            }

            double averageCarsHorsepower = totalCarsHorsepower / onlyCars.Count;
            double averageTrucksHorsepower = totalTrucksHorsepower / onlyTrucks.Count;
            if (averageCarsHorsepower > 0 && averageTrucksHorsepower > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
            }
            else if (averageCarsHorsepower > 0 && averageTrucksHorsepower <= 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsepower:f2}.");
            }
            else if (averageCarsHorsepower <= 0 && averageTrucksHorsepower > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsepower:f2}.");
            }
        }
        class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsePower)
            {
                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsePower;

            }

            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
            public override string ToString()
            {
                string vehicleStr = $"Type: {(this.Type == "car" ? "Car" : "Truck")}{Environment.NewLine}" +
                                    $"Model: {this.Model}{Environment.NewLine}" +
                                    $"Color: {this.Color}{Environment.NewLine}" +
                                    $"Horsepower: {this.HorsePower}";

                return vehicleStr;
            }


        }
    }
}
