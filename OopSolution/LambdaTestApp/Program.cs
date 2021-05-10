using System;

namespace LambdaTestApp
{
    class Program
    {
        //delegate void DoSTH();
        delegate void DoSTH(string name);
        delegate string Concatenate(string[] arr);

        static void Main(string[] args)
        {
            //anonymous func
            /*DoSTH doIt = delegate () //람다화  : delegate 삭제 ()만 남기고 => 붙인다.
            {
                Console.WriteLine("Hello,");
                Console.WriteLine("John Doe");
            };*/

            /*DoSTH doIt = () =>
            {
                Console.WriteLine("Hello,");
                Console.WriteLine("John Doe");
            };*/

            DoSTH doIt = (name) =>
            {
                Console.WriteLine("Hello,");
                Console.WriteLine($"{name} Doe");
                return; // void는 return이 생략됨, return값이 없는 것
            };

            string name = "HHH";

            doIt(name);

            Concatenate concat = (arr) =>
            {
                string Result = "";
                foreach (var item in arr)
                {
                    Result += item;
                }
                return Result;
            };

            string[] strArr = { "아버지가", "가방에", "들어가신다" };
            Console.WriteLine(concat(strArr));


            Func<int> func1 = () => 3;
            var val = func1();
            Console.WriteLine($"val value is {val}");


            Func<int, int, int> plus = (x,y) => x+y; // *=>이후 값 == return값
            Console.WriteLine($"3 + 5 is {plus(3 , 5)}");

            
            Action<int> area = (r) =>
            {
                Console.WriteLine($"원의 넓이는 {(double)r * r * Math.PI}");
            };
            area(10);

            //Expression Tree

        }
    }
}
