﻿using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;

namespace JSONSerializer
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = $"{DateTime.Now:yyyy-MM-dd-hh-mm-ss-fff}.log";
            string filePath = $"{Directory.GetCurrentDirectory()}{fileName}";

            LogFile jsonLogFile = new LogFile(filePath, fileName);
            Log jsonLog = new Log("Program.Main", "This is the content of the Log", jsonLogFile);

            Console.WriteLine("Output of Log:");
            jsonLog.PrintLog();

            StreamWriter sw = new StreamWriter(filePath, false, Encoding.UTF8);

            sw.Write(JsonSerializer.Serialize(jsonLog));
            sw.Close();

            StreamReader sr = new StreamReader(filePath, Encoding.UTF8);

            Log readJsonLog = JsonSerializer.Deserialize<Log>(sr.ReadToEnd());
            sr.Close();

            Console.WriteLine("Read Json Log:");
            readJsonLog?.PrintLog();
        }
    }
}
