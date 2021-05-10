using System;

namespace DelegateChainTestApp
{
    delegate int Calculate(int a, int b);//calc delegate선언

    class Program
    {
        static void Main(string[] args)
        {
            #region delegate chain
            FireStation Station = new FireStation();
            ThereIsAFire firehouse = new ThereIsAFire(Station.Call119);
            firehouse += new ThereIsAFire(Station.ShotOut);
            firehouse += new ThereIsAFire(Station.Escape);

            //delegate 실행
            firehouse("Our House");

            Console.WriteLine();

            ThereIsAFire fireWoorim = new ThereIsAFire(Station.Call119);
            //fireWoorim += new ThereIsAFire(Station.ShotOut);
            fireWoorim += new ThereIsAFire(Station.Escape);

            //delegate 실행
            fireWoorim("Woorim LionValleyA");
            #endregion

            Calculate calc;
            /*calc = delegate (int a, int b) // Calculate class의 plus함수와 같은 역할 , anonymous 함수, 일반식
             {
                 return a + b;
             }; //(**람다식으로 줄여서 표현 가능하다 21.05.10) */

            calc = (a, b) => a + b; //anonymous 함수 의 람다식 표현
            
            Console.WriteLine($"a + b = {calc(3, 5)}");
        }
    }
}
