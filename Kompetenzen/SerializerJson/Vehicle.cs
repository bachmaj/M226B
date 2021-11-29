using System;
using System.Collections.Generic;
using System.Text;

namespace SerializerJson
{
    [Serializable]
    public class Vehicle
    {
        public string Brand { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
        }
    }
}
