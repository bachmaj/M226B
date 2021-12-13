using System;

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



            Console.WriteLine("Specify Employees Id");
            int employeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Specify Employees age");
            int employeeAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Specify Employees name");
            string employeeName = Console.ReadLine();

            Console.WriteLine("Specify Employees company");
            string employeeCompany = Console.ReadLine();

            Employee employee = new Employee(employeeCompany, employeeId, employeeAge, employeeName);

            employee.PrintInfo();



            Console.WriteLine("\n\nSpecify Customers Id");
            int customerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Specify Customers age");
            int customerAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Specify Customers name");
            string customerName = Console.ReadLine();

            Console.WriteLine("Specify Customers company");
            string customerCity = Console.ReadLine();

            Employee customer = new Employee(customerCity, customerId, customerAge, customerName);

            customer.PrintInfo();
        }
    }
}
