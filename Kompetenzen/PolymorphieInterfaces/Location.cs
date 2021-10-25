using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphieInterfaces
{
    public class Location : BaseModel, ILocation
    {
        private object _currentVisitors;

        public object Children { get; set; }

        public object Employees { get; set; }

        public string Name { get; set; }

        public object Parent { get; set; }

        public object Vehicles { get; set; }

        public Location()
        {

        }

        public void AddChild()
        {

        }

        public void AvailableCars()
        {

        }

        public void GetAvailableVehicles()
        {

        }

        public void GetFreeSalesManagers()
        {

        }

        public void PrintStatistics()
        {

        }

        public void SetParent()
        {

        }

        public void Visit()
        {

        }

        public void GetAvailableVehicle()
        {
            throw new NotImplementedException();
        }
    }
}
