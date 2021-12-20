using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelsmanagement
{
    public class Employee : Person, IPrintable
    {
        public Employee(string company, int id, int age, string name) : base(id, age, name)
        {
            Company = company;
        }

        public string Company { get; set; }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Company: " + Company);
        }
    }
}