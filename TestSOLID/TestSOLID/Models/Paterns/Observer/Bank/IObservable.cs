using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.Bank
{
    interface IObservable
    {
        void RegisterObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }
}
