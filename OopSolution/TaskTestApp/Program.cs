using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myTask = Task.Factory.StartNew(() =>
            {//Task로 비동기 처리할 내용
                Thread.Sleep(1000);//1초간 작업처리 , 대규모일 때

            });
            //Console.WriteLine("Hello World!");
        }
    }
}
