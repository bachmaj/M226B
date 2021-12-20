using System;
using System.Collections.Generic;
using System.Linq;

namespace Modelsmanagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Specify Persons Id");
            int personId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Specify Persons age");
            int personAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Specify Persons name");
            string personName = Console.ReadLine();

            Person person = new Person(personId, personAge, personName);

            person.PrintInfo();



            Console.WriteLine("\n\nSpecify Employees Id");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Specify Employees age");
            int employeeAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Specify Employees name");
            string employeeName = Console.ReadLine();

            Console.WriteLine("Specify Employees company");
            string employeeCompany = Console.ReadLine();

            Person employee = new Employee(employeeCompany, employeeId, employeeAge, employeeName);

            employee.PrintInfo();

            Logger logger = new Logger();



            Console.WriteLine("\n\nSpecify Customers Id");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Specify Customers age");
            int customerAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Specify Customers name");
            string customerName = Console.ReadLine();

            Console.WriteLine("Specify Customers city");
            string customerCity = Console.ReadLine();

            Person customer = new Customer(customerCity, customerId, customerAge, customerName);

            customer.PrintInfo();



            List<Person> persons = new List<Person>()
            {
                person,
                employee,
                customer
            };

            persons = persons.Where(x => DateTime.Now - x.ActiveSince > new TimeSpan(0, 0, 45)).ToList();
            persons.OrderBy(x => x.Id);

            foreach(Person listPerson in persons)
            {
                listPerson.Id++;
            }

            persons.First().PrintInfo();
        }
    }
}
