using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerJson
{
    [Serializable]
    class Truck : Vehicle
    {
        public int Weight { get; set; }
    }
}
