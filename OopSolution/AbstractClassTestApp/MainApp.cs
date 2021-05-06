using System;

namespace AbstractClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derieved();
            obj.PublicMethod();
            obj.AbstractMethod();
        }
    }
}
