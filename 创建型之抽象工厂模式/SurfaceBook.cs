using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    internal class SurfaceBook : IComputer
    {
        public void PrintComputer()
        {
            Console.WriteLine("this is surfacebook computer");
        }
    }
}
