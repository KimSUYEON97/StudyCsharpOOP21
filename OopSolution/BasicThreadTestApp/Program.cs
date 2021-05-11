using System;
using System.Threading;

namespace BasicThreadTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoSth();
            //Thread th1 = new Thread(new ThreadStart(DoSth));// DoSth설정 Threadstart대리자, Thread실행
            Thread th1 = new Thread(DoSth);//ThreadStart 대리자를 생략해도 동일하게 작동함
            th1.Start();
            th1.Join(); //스레드 종료 대기
            DoOth();

            //th1.Abort();//에러 발생! 더이상 사용하지 않는다.
            th1.Interrupt();//스레드를 wait,join,sleep상태일때 중단시키는 메소드
        }

        private static void DoOth()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"Do Oth : {i}");
                Thread.Sleep(10);//10ms 대기
            }
            //throw new NotImplementedException();
        }

        private static void DoSth()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"Do Sth : {i}");
                Thread.Sleep(10);//대기상태, 넣으면 순서가 달라진다
            }
            //throw new NotImplementedException();
        }
    }
}
