using System;

namespace GenericMyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INT 값 ");
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = i + 1;
            }


            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"{list[i]}\t");
            }
            Console.WriteLine();

            Console.WriteLine("\nSTRING 값 ");
            MyList<string> slist = new MyList<string>();
            for (int i = 0; i < slist.Length; i++)
            {
                slist[i] = "s"+(i+1);
            }


            for (int i = 0; i < slist.Length; i++)
            {
                Console.Write($"{slist[i]}\t");
            }
            Console.WriteLine();

            Console.WriteLine("\nOBJECT 값 ");
            MyList<object> olist = new MyList<object>();

            olist[0] = 111;
            olist[1] = 3.14f;
            olist[2] = "tired";

            for (int i = 0; i < olist.Length; i++)
            {
                Console.Write($"{olist[i]}\t");
            }
            Console.WriteLine();
        }
    }
}
