using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    internal class SingletonTest
    {
        private static SingletonTest instance = null;
        private static readonly object instanceLock = new object();

        private SingletonTest() { }
        public static SingletonTest Instance
        {
            get
            {
                // 双重判定
                if (instance == null)// 只有当实例为null时才进行加锁处理
                {
                    lock (instanceLock)
                    {
                        if (instance==null)// 避免其他线程在等待锁释放阶段已经实例化了，从而造成多个实例
                        {
                            instance = new SingletonTest();
                        }
                    }
                }
                return instance;
            }
        }


        public void Show()
        {
            Console.WriteLine("SingletonTest");
        }
    }
}
