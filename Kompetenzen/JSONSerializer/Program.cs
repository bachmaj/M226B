using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace JSONSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = Directory.GetCurrentDirectory().ToString() + "BinaryFile.bin";
            IFormatter binaryFormatterObject = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {

            }
        }
    }
}
