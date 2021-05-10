using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeTestApp;
using System;

namespace CalcUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod("Plus Test")]//attributeȰ�� , �ּ� ���� ��Ÿ������ �ڵ���
        public void TestMethod1()
        {
            MyClass myClass = new MyClass();
            int a = 3;
            int b = 5;
            var result = myClass.Plus(a, b);

            Assert.AreEqual(8,result);//8�� result���� �������� ���� üũ, �׽�Ʈ ��� üũ
            
        }

        [TestMethod("Divide Test")]//���� �����ָ� �׽�Ʈ ����� Ȯ�� �Ұ���
        public void DivideTest()
        {
            MyClass myClass = new MyClass();
            int a = 10, b = 3;
            var result = myClass.Divide(a, b);//divide�Լ��� return�� a%b�̸�
            var expected = 3;

            Assert.AreEqual(expected, result);//���⼭ ������ �߻�! -> a/b�� �ٲپ��־�� ���� �� �� �ִ�.
            //print�� test�� ���� �ʴ�.
        }
    }
}
