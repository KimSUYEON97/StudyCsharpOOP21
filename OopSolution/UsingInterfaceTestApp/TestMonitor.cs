using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    class TestMonitor//Ver 1.0
    {
        private ILogger logger;

        public TestMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void PrintLog(string msg)
        {
            this.logger.WriteLog(msg);
        }
    }
}
