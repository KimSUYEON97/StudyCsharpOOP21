using System;

namespace IndexerTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyList example!");

            MyList list = new MyList();

            for (int i = 0; i < 5; i++)
            {
                list[i] = (i + 1);
            }//예외 발생! why? 설정한 값이 3인데 i == 5이므로 -> 외부에서 쓸때 잘못 쓰지 않도록 resize 예외처리 필요

            for (int i = 0; i < list.Length ; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
