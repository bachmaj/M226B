using System;
using System.Linq;

namespace PolymorphieInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IManageableEntity manageablePerson = new Person();
            Employee salesManager = new SalesManager();
            ILocation location = new Location();

            manageablePerson.AddChild(salesManager);
            salesManager.Location = location;
            location.Name = "Zurich";
        }
    }
}
