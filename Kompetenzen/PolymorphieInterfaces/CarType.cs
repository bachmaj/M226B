using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphieInterfaces
{
    public class CarType : BaseModel, ICarType
    {
        public string Name { get; set; }

        public object GetCarType { get; set; }
    }
}
