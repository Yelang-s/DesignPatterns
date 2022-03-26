using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    internal class MacbookComputer : IComputer
    {
        public void PrintComputer()
        {
            Console.WriteLine("this is macbook computer");
        }
    }
}
