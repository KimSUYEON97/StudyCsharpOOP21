using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    interface ILogger//상속시 아래의 액션(method)을 무조건 구현해야한다.
    {
        void WriteLog(string msg);//하나의 메세지를 받아 처리할 것

        void WriteError(string err);//method 추가
    }
}
