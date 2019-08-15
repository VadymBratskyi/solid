using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.News2.Widgets
{
    public class TvWidget2 : IObserverNews2, IWidget2
    {
        private string TvMessage;
        private ISubjectNews2 _subject;

        public TvWidget2(ISubjectNews2 subject)
        {
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

        public void Update(object sender, NewsEventArgs2 args)
        {
            TvMessage = args.Tv;
            Display();
        }
    }
}
