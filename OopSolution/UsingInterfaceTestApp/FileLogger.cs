using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);//file 형성작업
            writer.AutoFlush = true;//자동 data작성 여부
        }

        public void WriteLog(string msg)
        {
            writer.WriteLine($"Filelog {DateTime.Now}\t>>>>>\t{msg}");// \t = 4 spacebar
            //throw new NotImplementedException();
        }
    }
}
