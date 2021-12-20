using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelsmanagement
{
    public class Car : IPrintable
    {
        public Car(string manufacturer, string model, int horsepower, int buildYear)
        {
            Manufacturer = manufacturer;
            Model = model;
            Horsepower = horsepower;
            BuildYear = buildYear;
        }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Horsepower { get; set; }

        public int BuildYear { get; set; }


        public void PrintInfo()
        {
            Console.WriteLine("\nCar Info:");
            Console.WriteLine("Manufacturer: " + Manufacturer);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Horsepower: " + Horsepower);
            Console.WriteLine("Build year: " + BuildYear);
        }
    }
}
