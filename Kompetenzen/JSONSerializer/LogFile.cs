using System;

namespace JSONSerializer
{
    [Serializable]
    public class LogFile
    {
        public string Path { get; private set; }

        public string FileName { get; private set; }

        public LogFile(string path, string fileName)
        {
            Path = path;
            FileName = fileName;
        }
    }
}