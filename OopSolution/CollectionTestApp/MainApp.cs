using System;
using System.Collections;

namespace CollectionTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {

            /*int a = 123;
            object obj = a;
            int b = (int)obj;

            Console.WriteLine("a value = " + a);
            Console.WriteLine("obj value = " + obj);
            Console.WriteLine("b value = " + b);

            string str = "문자열";
            obj = (object)str;

            Console.WriteLine("str value = " + str);
            Console.WriteLine("obj value = " + obj);*/

            Console.WriteLine("ArrayList example");

            ArrayList list = new ArrayList();//사이즈 지정 하지 x
            /*list.Add(3);
            list.Add(10.0f);
            list.Add(90.23);
            list.Add(123);
            list.Add(23);//다양한 type받을 수 있다 object기본*/

            list.Add(3);
            list.Add(10);
            list.Add(90);
            list.Add(123);
            list.Add(23);

            foreach (var item in list)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            list.Sort();// sort를 위해서는 원소가 모두 같은 타입이어야 한다.

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            list.Reverse();

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            list.Add(100);//resize필요 없음

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            list.Insert(2, 88);

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            list.RemoveAt(5);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            int index100 = list.IndexOf(100);
            Console.WriteLine($"100 위치  = {index100}");

            list.Remove(88);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            list.Add(14);

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index14 = list.IndexOf(14);
            Console.WriteLine($"14 위치  = {index14}");

            int lstindex14 = list.LastIndexOf(14);
            Console.WriteLine($"14 위치  = {lstindex14}");

            Console.WriteLine($"total {list.Count}");
            Console.WriteLine($"lst last value = {list.[list.Count - 1]}");

        }
    }
}
