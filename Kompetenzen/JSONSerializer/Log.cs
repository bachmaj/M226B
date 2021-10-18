using System;

namespace JSONSerializer
{
    [Serializable]
    public class Log : LogBase
    {
        public LogFile LoggedInFile { get; private set; }

        public Log(string source, string content, LogFile loggedInFile) : base(source, content)
        {
            LoggedInFile = loggedInFile;
        }

        public override void PrintLog()
        {
            base.PrintLog();
            Console.WriteLine($"\tLogged In :\t{LoggedInFile.FileName}\n");
        }
    }
}