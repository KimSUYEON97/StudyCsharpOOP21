using System;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("예외 발생");

            int[] array = new int[5];

            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    array[i] = (i + 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} 관리자에게 문의 하세요. Main (17~)");
                //throw;
            }//catch는 계속 이어갈 수 있다.

            Console.WriteLine("다른 로직 수행");
            //...

            int[] list = { 107, 108, 109 };
            try
            {
                string msg = null;
                Console.WriteLine(msg.Length);

                var result = list[1] / 0;
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            /*catch (IndexOutOfRangeException o)
            {
                Console.WriteLine($"예외발생 : {o.Message}");
                //IndexOutOfRangeException 발생시 다른 일 처리
                Console.WriteLine("IndexOutOfRangeException after process");
                //throw;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("DivideByZeroException after process");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("NullReferenceException after process");
            }//catch를 일일히 잡을 경우 코드가 복잡해지므로 -> 부모 Exception으로 모든 에러를 처리한다.*/
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                //throw;
            }
            finally
            {
                //오후에
            }

            Console.WriteLine("프로그램 종료!");//
        }
    }
}
