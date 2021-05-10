using System;

namespace AttributeTestApp
{
    public class MyClass//외부에서 참조접근 하기 위해 public 추가
    {
        //properties...

        //methods
        [Obsolete("This Method is deleted. Change into NewMethod().")] //Main문에 oldmethod사용 될 경우 알람 표시됨, oldMethod 사용은 가능 but 다른 것을 사용하도록 유도하는것
        public void OldMethod() { Console.WriteLine("Do Sth"); }
        public void NewMethod() { Console.WriteLine("Do Sth NEW"); }

        public int Plus(int a,int b) { return a + b; }
        public int Divide(int a, int b) { return a / b; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mine = new MyClass();
            mine.OldMethod();
            mine.NewMethod();

            var result = mine.Plus(3, 5);
            Console.WriteLine(result);
        }
    }
}
