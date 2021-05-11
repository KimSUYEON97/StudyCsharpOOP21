using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParellelTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. normal way
            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
            }
            Console.Read();


            DateTime startTime = DateTime.Now;

            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
            }
            TimeSpan procTime = DateTime.Now - startTime;
            Console.WriteLine($"for 10000처리시간 : {procTime.TotalMilliseconds} ms");
            Console.Read();

            //2.Parallel
            DateTime pStartTime = DateTime.Now;
            Parallel.For(0, 10000, (i) =>
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}: {i}");
                //Thread.CurrentThread.ManagedThreadId 어느 Thread가 실행중인지 확인 가능
            });

            TimeSpan pProcTime = DateTime.Now - pStartTime;
            Console.WriteLine($"Parallel for 1000처리시간 : {pProcTime.TotalMilliseconds} ms");
            Console.Read();
            
        }
    }
}
