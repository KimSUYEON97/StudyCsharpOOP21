using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ThreadLockTestApp
{
    class Counter
    {
        private int counter = 1000;
        private object thislock = new object();
        public void Run()
        {
            for (int i = 0; i < 10; i++)//thread10개가 생성 후 unsafecalc에 접근
            {
                Thread th = new Thread(UnsafeCalc);
                th.Start();
            }
        }
        public void UnsafeCalc()
        {
            lock (thislock)//lock을 이용한 동기화, 다른스레드가 접근 못하도록 처리
            {
                counter++;
                
                Thread.Sleep(10);

                Console.WriteLine(counter);//counter값 모두 다름
            }
            /*counter++;
            *//*for (int i = 0; i < counter; i++)
            {
                for (int j = 0; j < counter; j++)
                {
                    //Do sth
                }
            }*//*//Thread Sleep으로 대체 가능
            Thread.Sleep(10);//counter값 모두 동일

            Console.WriteLine(counter);*/
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter obj = new Counter();
            obj.Run();

            //Console.WriteLine($"obj.count = {obj.Count}");
        }
    }
}
