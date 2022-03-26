using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    internal class Win11 : IComputerSystem
    {
        public void ShowSystem()
        {
            Console.WriteLine("Win11 System");
        }
    }
}
