using System;

namespace DelegateTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //일반적 호출
            Calculator calc = new Calculator();
            Console.WriteLine($"3 + 5 = {calc.Plus(3,5)}");
            Console.WriteLine($"3 / 5 = {calc.Divide(3,5)}");

            //delegate 대리자 호출, 대리자 사용 이유? 코드를 대신 실행해주는 객체
            CalcDelegate callback; 
            callback = new CalcDelegate(calc.Plus); //calc.Plus 소스코드를 넘겨주는 역할. == 대리자
            Console.WriteLine($"3 + 5 = {callback(3, 5)}");//두개의 값을 받아야 한다
            callback = new CalcDelegate(calc.Multiple);
            Console.WriteLine($"3 * 5 = {callback(3, 5)}");
        }
    }
}
