using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 行为型模式之观察者模式
{
    internal class AlarmObserver : IObserver
    {
        public async void Update(object obj)
        {
            Console.WriteLine($"Alarm:{obj}");
            await System.Threading.Tasks.Task.Delay(5000);
        }
    }
}
