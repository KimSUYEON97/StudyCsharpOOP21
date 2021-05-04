using System;
using System.Threading;

namespace UsingInterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //이전 3000라인 생랙
            var monitor = new TestMonitor(new ConsoleLogger(DateTime.Now));

            monitor.PrintLog("logging");

            var monitor1 = new TestMonitor(new FileLogger("210504.log"));//console이 아닌 private에 입력됨

            monitor1.PrintLog("logging");

            Thread.Sleep(5000);//5초 , 1000ms = 1sec
            //이하 1400라인 생략

            monitor1.PrintLog("error occured below");
            Console.WriteLine("program end");
        }
    }
}
