using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTestApp
{
    abstract class AbstractBase
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("AbstractBase.ProtectedMethod() executed");
        }

        public void PublicMethod()
        {
            Console.WriteLine("AbstractBase.PublicMethod() executed");
        }

        public abstract void AbstractMethod();//interface 선언과 동일
    }
}
