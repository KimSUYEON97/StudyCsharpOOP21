using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTestApp
{
    delegate void EventHandler(string msg);//delegate 선언
    class MyNotifier
    {
        public event EventHandler SthHappend;

        public void DoSth(int num)
        {
            int temp = num / 10;
            if (temp == 3 || temp == 6 || temp == 9 || num % 10 == 3 || num % 10 == 6 || num % 10 == 9)
            {
                SthHappend($"짝\t");
            }
            else
            {
                SthHappend($"{num}\t");
            }
        }
    }
}
