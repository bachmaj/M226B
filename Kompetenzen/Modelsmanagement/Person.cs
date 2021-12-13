using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelsmanagement
{
    public class Person
    {
        public Person()
        {

        }

        public Person(int id, int age, string name)
        {
            Id = id;
            Age = age;
            Name = name;
            ActiveSince = DateTime.Now;
        }

        public int Id { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public DateTime ActiveSince { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine("\nPerson Info:");
            Console.WriteLine("Id: " + Id );
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ActiveSince: " + ActiveSince);
        }
    }
}
