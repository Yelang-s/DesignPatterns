using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    工厂方法模式和抽象工厂模式的区别:
    当工厂只生成一个产品时即为工厂方法模式
    当工厂生产两个及以上时，即为抽象工厂模式
 
 
 */
namespace 抽象工厂模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IComputerFactory factory = new AppleFactory();
            IComputerFactory factory = new MSFactory();
            IComputer computer = factory.GetComputer();
            IComputerSystem system = factory.ShowSystem();

            computer.PrintComputer();
            system.ShowSystem();

            Console.ReadKey();
        }
    }
}
