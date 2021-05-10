using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeTestApp;
using System;

namespace CalcUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod("Plus Test")]//attribute활용 , 주석 등의 메타데이터 코드요소
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();
            int a = 3;
            int b = 5;
            var result = myClass.Plus(a, b);

            Assert.AreEqual(8,result);//8과 result값이 동일한지 여부 체크, 테스트 결과 체크
            
        }

        [TestMethod("Divide Test")]//설정 안해주면 테스트 실행시 확인 불가함
        public void DivideTest()
        {
            MyClass myClass = new MyClass();
            int a = 10, b = 3;
            var result = myClass.Divide(a, b);//divide함수의 return이 a%b이면
            var expected = 3;

            Assert.AreEqual(expected, result);//여기서 에러가 발생! -> a/b로 바꾸어주어야 함을 알 수 있다.
            //print의 test는 쉽지 않다.
        }
    }
}
