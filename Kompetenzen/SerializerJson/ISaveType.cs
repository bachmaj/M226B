using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerJson
{
    public interface ISaveType
    {
        public static string FileNameCar { get; set; }
        public static string FileNameTruck { get; set; }

        public void SaveInClass(Vehicle vehicle, List<Vehicle> list);

    }
}
