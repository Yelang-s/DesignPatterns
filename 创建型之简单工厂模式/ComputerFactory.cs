using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    internal class ComputerFactory
    {
        public IComputer GetComputer(string type)
        {
            if (type == null)
            {
                return null;
            }

            switch (type.ToLowerInvariant())
            {
                case "macbook":
                    return new MacbookComputer();
                case "surface":
                    return new SurfaceBookComputer();   
                default:
                    break;
            }

            return null;
        }
    }
}
