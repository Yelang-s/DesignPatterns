using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    单例模式：
    该类负责自己创建自己的实例，同时确保只有单个对象被创建，对外提供唯一的访问对象的方法，可以直接访问对象，不需要
初始化
    
    注：
    单例类只能有一个实例
    单例类必须自己创建自己的实例
    
    何时使用：当想控制实例的数目时使用

    关键：构造函数私有化，对外提供唯一可访问实例的方法或者属性

    
 
 */
namespace 单例模式
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SingletonTest test = new SingletonTest();
            var test = SingletonTest.Instance;
            var test1 = SingletonTest.Instance;



            if (test.Equals(test1))
            {
                Console.WriteLine("===");
            }
            else
            {
                Console.WriteLine("!=");
            }

            Console.ReadKey();

        }
    }
}
