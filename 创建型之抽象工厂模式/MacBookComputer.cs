﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    internal class MacBookComputer : IComputer
    {
        public void PrintComputer()
        {
            Console.WriteLine("this is macbook computer");
        }
    }
}
