using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer
{
    class ConcreteObservable : IObservable
    {
        private List<IObserver> observers;

        public ConcreteObservable() {
            observers = new List<IObserver>();
        }

        public void AddObservable(IObserver o)
        {
            observers.Add(o);
        }

        public void NotifyObservable()
        {
            foreach (IObserver observer in observers) {
                observer.Update();
            }
        }

        public void RemoveObservable(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
