using System;

namespace GenericTestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INT 값 ");

            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length]; // = {0,0,0,0,0}

            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();//copy 전

            CopyArray<int>(sourceInt, targetInt);

            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();//copy 후

            Console.WriteLine("FLOAT 값 ");
            float[] sourceFloat = { 1.2f, 2.3f, 2.4f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length]; // = {0,0,0,0,0}

            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();//copy 전

            CopyArray<float>(sourceFloat, targetFloat);

            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();//copy 후

            Console.WriteLine("STRING 값 ");
            string[] sourceString = { "하나", "둘", "셋", "넷", "다섯" };
            string[] targetString = new string[sourceString.Length];

            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();//copy 전

            CopyArray<string>(sourceString, targetString);

            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();//copy 후

        }

        //일반화 method통일
        private static void CopyArray<T>(T[] source, T[] target)//어떤 type이던 모두 들어 갈 수 있다.== T!
        {
            
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
            //throw new NotImplementedException();
        }
        
    }
}
