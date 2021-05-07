using System;

namespace GenericTestApp
{
    class MainApp //일반화 --> GenericTestApp2와 비교
    {
        static void Main(string[] args)
        {
            int[] sourceInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourceInt.Length]; // = {0,0,0,0,0}

            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();//copy 전

            CopyArray(sourceInt, targetInt);

            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();//copy 후


            float[] sourceFloat = { 1.2f, 2.3f,2.4f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length]; // = {0,0,0,0,0}
            
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();//copy 전

            CopyArray(sourceFloat, targetFloat);

            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();//copy 후


            string[] sourceString = { "하나", "둘", "셋", "넷", "다섯" };
            string[] targetString = new string[sourceString.Length];

            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();//copy 전

            CopyArray(sourceString, targetString);

            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();//copy 후

        }

        private static void CopyArray(string[] source, string[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
            //throw new NotImplementedException();
        }

        private static void CopyArray(float[] source, float[] target)//생산자 오버로딩
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
            //throw new NotImplementedException();
        }

        private static void CopyArray(int[] source, int[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
            //throw new NotImplementedException();
        }
    }
}
