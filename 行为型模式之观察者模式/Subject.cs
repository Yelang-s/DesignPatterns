using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 行为型模式之观察者模式
{
    internal class Subject
    {

        private List<IObserver> observers = new List<IObserver>();
        
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(object obj)
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(obj);
            }
        }
    }
}
