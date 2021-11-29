using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerJson
{
    [Serializable]
    public class Car : Vehicle
    {
        public int Price { get; set; }


        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Price: {Price}");
        }

    }
}
