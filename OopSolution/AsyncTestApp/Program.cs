using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Caller();
            //Console.WriteLine("Hello World!");
        }

        private static void Caller()
        {
            Console.WriteLine("caller A");
            Console.WriteLine("caller B");


            MyMethodAsync(3);//Async처리


            Console.WriteLine("caller C");
            Console.WriteLine("caller D");
            //throw new NotImplementedException();
        }

        private async static void MyMethodAsync(int count)
        {
            Console.WriteLine("My C");
            Console.WriteLine("My D");

            /*for (int i = 0; i <= count; i++)
            {
                Console.WriteLine($"{i}/{count} ...");
            }*///normal

            await Task.Run(async () =>
            {
                for (int i = 1; i <= count; i++)
                { 
                    Console.WriteLine($"{i}/{count} ...");
                    await Task.Delay(10);
                }
            });//async way


            Console.WriteLine("My G");
            Console.WriteLine("My H");
            //throw new NotImplementedException();
        }
    }
}
