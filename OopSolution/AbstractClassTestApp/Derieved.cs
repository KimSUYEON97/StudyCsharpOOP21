using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTestApp
{
    class Derieved : AbstractBase
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Derieved.AbstractMethod() executed");
            base.ProtectedMethod();
            //throw new NotImplementedException();
        }
    }
}
