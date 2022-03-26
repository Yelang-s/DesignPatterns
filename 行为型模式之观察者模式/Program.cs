using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    观察者模式：
    定义对象间的一对多的依赖关系，当一个对象的状态发生变化时，所有依赖与它的对象都能得到通知

    注意
        如果观察者存在耗时长的话，一般采用异步操作
 
 
 */
namespace 行为型模式之观察者模式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();    
            subject.AddObserver(new AlarmObserver());   
            subject.AddObserver(new LightAlarmObserver());

            subject.Notify("报警了");

            Console.ReadKey();  

        }
    }
}
