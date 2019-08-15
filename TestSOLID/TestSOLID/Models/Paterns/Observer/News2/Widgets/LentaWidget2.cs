using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.News2.Widgets
{
    public class LentaWidget2 : IObserverNews2, IWidget2
    {
        private string LentaMessage;
        private ISubjectNews2 _subject;

        public LentaWidget2(ISubjectNews2 subject) {
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

        public void Update(object sender, NewsEventArgs2 args)
        {
            LentaMessage = args.Lenta;
            Display();
        }
    }
}
