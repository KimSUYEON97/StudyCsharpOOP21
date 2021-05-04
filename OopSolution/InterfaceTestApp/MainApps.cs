using System;

namespace InterfaceTestApp
{
    class MainApps
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using ILogger\n");

            ILogger logger = new ConsoleLogger();//자동 형변환
            logger.WriteLog("Basic console logger!");
            logger.WriteError("error msg!");

            /*ILogger clmlogger = new ClimateLogger();
            clmlogger.WriteLog("sunny");*/

            //interface를 사용해 코드 수정 간편
            ILogger clmlogger = new FileLogger();//Ver 1.0 ClimateLogger->Ver 1.2 FileLogger변경
            clmlogger.WriteLog("sunny");
            clmlogger.WriteError("problem occur!!!");

            ILogger logger2 = new ClimateLogger();
            logger2.WriteLog("cloudy");
            //logger2.WriteError("!!!!");//실행오류 예외 발생됨
        }
    }
}
