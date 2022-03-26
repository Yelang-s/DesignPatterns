using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 行为型模式之观察者模式
{
    internal interface IObserver
    {
        void Update(object obj);
    }
}
