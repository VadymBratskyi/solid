using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.News2.Widgets
{
    public class TwitterWidget2 : IObserverNews2, IWidget2
    {
        private string TwitterMessage;
        private ISubjectNews2 _subject;

        public TwitterWidget2(ISubjectNews2 subject)
        {
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

        public void Update(object sender, NewsEventArgs2 args)
        {
            TwitterMessage = args.Twitter;
            Display();
        }
    }
}
