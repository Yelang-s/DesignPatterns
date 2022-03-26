using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
    简单工厂模式：
        1. 工厂角色：ComputerFactory，用于内部创建具体的对象
        2. 抽象产品类：ICOmputer，描述公共接口
        3. 具体产品类：MacbookComputer、SurfaceBookComputer，实现IComputer抽象类的接口，是工厂角色中药创建的具体实例


    缺点：
        违反“开闭原则”，因为如果需要新增具体产品，那么就需要修改工厂角色：ComputerFactory的代码

    优点：
        客户端不需要知道对象式如何产生的，只需要将相关信息提供给工厂即可

    由于简单工厂模式存在违反开闭原则，从而衍生出 工厂方法模式
 
 */
namespace 简单工厂模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComputerFactory factory = new ComputerFactory();
            IComputer computer = factory.GetComputer("macbook");
            computer.PrintComputer();
            IComputer computer1 = factory.GetComputer("surface");
            computer1.PrintComputer();
            Console.ReadKey();
        }
    }
}
