using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.News.Widgets
{
    public class TvWidget : IObserverNews, IWidget
    {
        private string TvMessage;
        private ISubjectNews _subject;

        public TvWidget(ISubjectNews subject) {
            _subject = subject;
            _subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Tv: {0}", TvMessage);
        }

        public void RemoveFromSubject()
        {
            _subject.RemoveObserver(this);
        }
               

        public void Update(string twitter, string lenta, string tv)
        {
            TvMessage = tv;
            Display();
        }
    }
}
