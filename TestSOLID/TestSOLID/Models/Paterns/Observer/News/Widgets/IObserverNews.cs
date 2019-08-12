using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.News.Widgets
{
    public interface IObserverNews
    {
        void Update(string twitter, string lenta, string tv);
        void RemoveFromSubject();
    }
}
