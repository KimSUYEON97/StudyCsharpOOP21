using System;
using System.Collections.Generic;

namespace GenericCollectionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic Collection Test\n");

            List<int> list = new List<int>();//Array에 비해 제약 발생하지만 성능적으로 좋음
            for (int i = 0; i <= 100; i++)
            {
                list.Add(i);
            }

            var sum = 0;

            foreach (var item in list)
            {
                sum += item;
            }

            Console.WriteLine($"1~100 sum = {sum}");

            list.RemoveAt(10);
            list.RemoveAt(20);
            list.RemoveAt(30);
            list.RemoveAt(40);
            list.RemoveAt(50);
            
            list.Insert(11, 5000);
            
            var index60 = list.IndexOf(60);
            Console.WriteLine($"index 60 is {index60}\n");

            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine("\n");

            Queue<string> lines = new Queue<string>();

            lines.Enqueue("1st customer");
            lines.Enqueue("2nd customer");
            lines.Enqueue("3rd customer");
            lines.Enqueue("4th customer");
            lines.Enqueue("5th customer");

            while (lines.Count > 0)
            {
                Console.WriteLine(lines.Dequeue());
            }
            Console.WriteLine();

            Dictionary<string, int> dics = new Dictionary<string, int>();
            dics["1st"] = 1;
            dics["2nd"] = 2;
            dics["3rd"] = 3;
            dics["4th"] = 4;
            dics["5th"] = 5;

            Console.WriteLine(dics["1st"]);
            Console.WriteLine(dics["2nd"]);
            Console.WriteLine(dics["3rd"]);

            foreach (var item in dics)
            {
                Console.WriteLine($"key - {item.Key} : value - {item.Value}");
            }
        }
    }
}
