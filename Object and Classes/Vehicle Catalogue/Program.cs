﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Catalog catalog = new Catalog();

            while (input != "end")
            {
                string[] vehicleInfo = input.Split('/');

                string vehicleType = vehicleInfo[0];
                string brand = vehicleInfo[1];
                string model = vehicleInfo[2];
                int value = int.Parse(vehicleInfo[3]);//hp or weight

                if (vehicleType == "Truck")
                {
                    Truck truck = new Truck(brand, model, value);
                    catalog.Trucks.Add(truck);
                }
                else
                {
                    Car car = new Car(brand, model, value);
                    catalog.Cars.Add(car);
                }

                input = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }

            foreach (var car in catalog.Cars
                .OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }

            foreach (var truck in catalog.Trucks
                .OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

    public class Catalog
    {
        public Catalog()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; } //Do i need ctor?

        public List<Truck> Trucks { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    public class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }
}