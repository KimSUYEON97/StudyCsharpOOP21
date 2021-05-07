using System;

namespace EventHandlerTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {

            Console.WriteLine("3,6,9! 3,6,9!");

            MyNotifier notifier = new MyNotifier();
            notifier.SthHappend += new EventHandler(MyHandler);
            //Event handler가 event발견시 Myhandler에게 실행요구, Eventhadler에 myhandler연결

            for (int i = 1; i <= 100; i++)
            {
                notifier.DoSth(i);
            }
        }

        private static void MyHandler(string msg)
        {
            //eventhandler에 실행할 내용 지정
            Console.Write(msg);
            //throw new NotImplementedException();
        }
    }
}
