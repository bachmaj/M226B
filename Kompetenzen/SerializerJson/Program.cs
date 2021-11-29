using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace SerializerJson
{
    class Program
    {
        public static string FileNameCar { get; set; } = @"C:\Users\bachmaj9\source\repos\M226B\Kompetenzen\SerializerJson\Daten\Car\car.json";
        public static string FileNameTruck { get; set; } = @"C:\Users\bachmaj9\source\repos\M226B\Kompetenzen\SerializerJson\Daten\Truck\truck.json";

        private static bool isRunning = true;
        private static string option;

        static void Main(string[] args)
        {
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();

            while (isRunning)
            {
                Console.WriteLine("Is vehicle car or truck");
                option = Console.ReadLine();

                if (option.ToLower() == "car")
                {
                    Car car = new Car();

                    Console.WriteLine("Enter the Price of the car");
                    car.Price = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Brand of the car");
                    car.Brand = Console.ReadLine();

                    car.PrintInfo();
                    cars.Add(car);
                    Save.SaveInClass(cars, FileNameCar);
                }
                else if (option == "truck")
                {
                    Truck truck = new Truck();

                    Console.WriteLine("Enter the weight of the truck");
                    truck.Weight = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Brand of the truck");
                    truck.Brand = Console.ReadLine();

                    truck.PrintInfo();
                    trucks.Add(truck);
                    Save.SaveInClass(trucks, FileNameTruck);
                }
                else
                {
                    Vehicle vehicle = new Vehicle()
                    {
                        Brand = "undefined"
                    };
                    vehicle.PrintInfo();
                }
            }
        }
    }
}


