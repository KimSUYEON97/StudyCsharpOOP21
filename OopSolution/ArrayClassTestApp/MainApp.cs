using System;
using System.Collections;

namespace ArrayClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Class");

            int[] array = new int[] { 5, 7, 3, 1, 9, 10, 4, 8, 2, 6 };
            
            foreach(var item in array)
            {
                Console.Write($"{item}\t");
            }

            Console.WriteLine();

            Array.Sort(array);

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }//오름차순

            Console.WriteLine();
            Array.Reverse(array);

            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }//내림차순

            Console.WriteLine();

            int index7 = Array.IndexOf(array, 7);
            Console.WriteLine($"index 7 = {index7}");

            Array.Resize<int>(ref array, 11);
            array[10] = 100;

            Console.WriteLine();
            foreach (var item in array)
            {
                Console.Write($"{item}\t");
            }

            //2중배열 int [,] = new int[0,0] 
        }
    }
}
