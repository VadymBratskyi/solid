using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.News.Widgets
{
    public class LentaWidget : IObserverNews, IWidget
    {
        private string LentaMessage;
        private ISubjectNews _subject;

        public LentaWidget(ISubjectNews subject) {
            _subject = subject;
            _subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Lenta: {0}", LentaMessage);
        }

        public void RemoveFromSubject()
        {
            _subject.RemoveObserver(this);
        }

        public void Update(string twitter, string lenta, string tv)
        {
            LentaMessage = lenta;
            Display();
        }
    }
}
