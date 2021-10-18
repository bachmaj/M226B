using System;
using System.IO;

namespace BinarySerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            // create file location
            string fileName = $"Log-{DateTime.Now:yyyy-MM-dd-hh-mm-ss-fff}.log";
            string filePath = @$"C:\Users\reglim\source\repos\Schule\01-M226B\M226B\JsonLogging\{fileName}";

            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);

            BinaryWriter binaryWriterObject = new BinaryWriter(fs);
        }
    }
}
