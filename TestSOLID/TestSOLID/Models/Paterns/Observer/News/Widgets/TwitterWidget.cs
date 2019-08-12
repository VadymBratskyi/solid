using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.News.Widgets
{
    public class TwitterWidget : IObserverNews, IWidget
    {
        private string TwitterMessage;
        private ISubjectNews _subject;

        public TwitterWidget(ISubjectNews subject) {
            _subject = subject;
            _subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Twitter: {0}", TwitterMessage);
        }

        public void RemoveFromSubject()
        {
            _subject.RemoveObserver(this);
        }
        
        public void Update(string twitter, string lenta, string tv)
        {
            TwitterMessage = twitter;
            Display();
        }
    }
}
