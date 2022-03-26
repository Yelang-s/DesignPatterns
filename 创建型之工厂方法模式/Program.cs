using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
    工厂方法模式：
        用来弥补 简单工厂模式的缺点
     
    将简单工厂模式中的 工厂角色 抽象成接口类，为每个产品提供一个工厂类
    
    优点：
        没有违背开闭原则，不需要感知对象的生成
        创建对象的逻辑：简单工厂模式的逻辑存在工厂角色中，工厂方法模式的创建对象的逻辑存在客户端中
        不需要去修改原有的代码
        
    缺点:
        每新增一个产品都需要去创建对应的工厂类和实现产品类，代码量增加

    
 
 */
namespace 工厂方法模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IComputerFactory factory = new AppleFactory();
            IComputerFactory factory = new MSFactory();
            IComputer computer = factory.GetComputer();
            computer.PrintComputer();

            Console.ReadKey();

        }
    }
}
