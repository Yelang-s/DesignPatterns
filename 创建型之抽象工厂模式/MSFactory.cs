using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    internal class MSFactory : IComputerFactory
    {
        public IComputer GetComputer()
        {
            return new SurfaceBook();
        }

        public IComputerSystem ShowSystem()
        {
            return new Win11();
        }
    }
}
