using System;
using System.Diagnostics;

namespace InterfaceTestApp
{
    class ConsoleLogger : ILogger
    {
        public void WriteError(string err)
        {
            Debug.WriteLine($"error : {err}");
            //throw new NotImplementedException();
        }

        public void WriteLog(string msg)//Ver 1.0개발
        {
            Console.WriteLine($"log{DateTime.Now} : {msg}");
            //throw new NotImplementedException();
        }
    }
}
