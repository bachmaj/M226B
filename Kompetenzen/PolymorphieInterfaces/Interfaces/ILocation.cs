using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphieInterfaces
{
    interface ILocation : IManageableEntity
    {
        public string Name { get; set; }

        void GetAvailableVehicles();

        void GetFreeSalesManagers();

        void Visit();
    }
}
