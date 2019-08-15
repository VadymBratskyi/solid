using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Observer.News.Widgets;
using TestSOLID.Models.Paterns.Observer.News2.Widgets;

namespace TestSOLID.Models.Paterns.Observer.News2
{
    public interface ISubjectNews2
    {
        void RegisterObserver(IObserverNews2 observer);
        void RemoveObserver(IObserverNews2 observer);
        void NotifyObserver();
    }
}
