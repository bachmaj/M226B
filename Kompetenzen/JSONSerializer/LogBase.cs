using System;

namespace JSONSerializer
{
    public abstract class LogBase
    {
        public DateTime LoggedOn { get; protected set; }

        public string Source { get; protected set; }

        public string Content { get; protected set; }

        protected LogBase(string source, string content)
        {
            LoggedOn = DateTime.Now;
            Source = source;
            Content = content;
        }

        public virtual void PrintLog()
        {
            Console.WriteLine($"Log of {LoggedOn}:");
            Console.WriteLine($"\tSource:\t\t{Source}");
            Console.WriteLine($"\tContent:\t{Content}");
        }
    }
}