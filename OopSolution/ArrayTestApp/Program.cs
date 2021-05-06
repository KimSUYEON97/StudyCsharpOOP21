using System;

namespace ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("대성마이맥 수학점수");

            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 70;
            scores[2] = 90;
            scores[3] = 60;
            scores[4] = 50;

            

            int sum = 0;

            foreach (var item in scores)
            {
                sum += item;
            }

            /*for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }*/

            float avg = (float)sum/scores.Length;

            Console.WriteLine($"Math score sum = {sum}, avg = {avg}");
        }
    }
}
