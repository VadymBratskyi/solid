using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.Bank
{
    class Stock : IObservable
    {
        StockInfo stockInfo; // информация о торгах

        List<IObserver> observers;

        public Stock() {
            observers = new List<IObserver>();
            stockInfo = new StockInfo();
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(stockInfo);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void Market() {

            Random rnd = new Random();
            stockInfo.USD = rnd.Next(25, 35);
            stockInfo.Euro = rnd.Next(30, 35);
            NotifyObservers();
        }
    }
}
