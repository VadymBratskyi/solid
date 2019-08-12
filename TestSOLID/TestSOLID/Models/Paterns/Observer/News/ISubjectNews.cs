using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Observer.News.Widgets;

namespace TestSOLID.Models.Paterns.Observer.News
{
    public interface ISubjectNews
    {
        void RegisterObserver(IObserverNews observer);
        void RemoveObserver(IObserverNews observer);
        void NotifyObserver();
    }
}
