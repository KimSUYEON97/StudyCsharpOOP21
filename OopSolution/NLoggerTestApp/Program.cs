using NLog;
using System;

namespace NLoggerTestApp
{
    class Program
    {
        static readonly Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            Console.WriteLine("Printing NLog");

            logger.Info("Start console program");
            logger.Warn("Warnning! program have to complete 000");
            logger.Error("Error Occur");

            Console.WriteLine("Printing NLog End");
        }
    }
}
