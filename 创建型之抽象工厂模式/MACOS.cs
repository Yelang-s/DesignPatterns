using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    internal class MACOS : IComputerSystem
    {
        public void ShowSystem()
        {
            Console.WriteLine("MAC OS System");
        }
    }
}
