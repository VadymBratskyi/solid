using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer
{
    interface IObservable
    {
        void AddObservable(IObserver o);
        void RemoveObservable(IObserver o);
        void NotifyObservable();
    }
}
