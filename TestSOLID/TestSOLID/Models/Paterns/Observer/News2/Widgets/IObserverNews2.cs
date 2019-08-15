using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.News2.Widgets
{
    public interface IObserverNews2
    {
        void Update(object sender, NewsEventArgs2 args);
        void RemoveFromSubject();
    }
}
