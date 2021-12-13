using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelsmanagement
{
    public class Customer : Person
    {
        public Customer(string city, int id, int age, string name) : base(id, age, name)
        {
            City = city;
        }

        public string City { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("City: " + City);
        }
    }
}