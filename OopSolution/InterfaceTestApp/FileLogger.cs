using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    class FileLogger : ILogger
    {
        public void WriteError(string err)
        {
            Debug.WriteLine($"File error : {err}");
            //throw new NotImplementedException();
        }

        public void WriteLog(string msg)//Ver 1.2에서 업데이트
        {
            Console.WriteLine($"save in file txt.log : {msg}");
            //throw new NotImplementedException();
        }
    }
}
