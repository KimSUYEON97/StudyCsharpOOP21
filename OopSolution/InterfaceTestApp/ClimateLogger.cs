using System;

namespace InterfaceTestApp
{
    class ClimateLogger : ILogger
    {
        public void WriteError(string err)
        {
            throw new NotImplementedException();
        }

        public void WriteLog(string weather)//Ver 1.0 개발
        {
            Console.WriteLine($"weather log [{DateTime.Now.ToShortDateString()}]: weather now - {weather}");
            //throw new NotImplementedException();

        }//string type이기만 하면 변수명은 상관 없다.
    }
}
