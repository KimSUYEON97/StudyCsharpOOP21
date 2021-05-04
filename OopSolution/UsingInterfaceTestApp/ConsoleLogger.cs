using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    class ConsoleLogger : ILogger
    {
        public DateTime CurrentDate { get; set; }

        public ConsoleLogger()
        {
        }

        public ConsoleLogger(DateTime currentDate)
        {
            this.CurrentDate = currentDate;
        }


        public void WriteLog(string msg)
        {
            Console.WriteLine($"console log : {this.CurrentDate} --> {msg}");
            //throw new NotImplementedException();
        }

        
    }
}
