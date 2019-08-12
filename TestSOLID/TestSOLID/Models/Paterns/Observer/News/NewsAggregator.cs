using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Observer.News.Widgets;

namespace TestSOLID.Models.Paterns.Observer.News
{
    public class NewsAggregator : ISubjectNews
    {
        private static Random random;
        private List<IObserverNews> observers;

        public NewsAggregator() {
            random = new Random();
            observers = new List<IObserverNews>();
        }

        public void NewNewsAvailable() {
            NotifyObserver();
        }

        public void NotifyObserver()
        {
            var twitter =  GetTwitter();
            var lenta = GetLenta();
            var tv = GetTv();

            foreach (IObserverNews observer in observers) {
                observer.Update(twitter, lenta, tv);
            }
        }

        public void RegisterObserver(IObserverNews observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserverNews observer)
        {
            observers.Remove(observer);
        }

        private string GetTwitter() {

            var arr =  new List<string> {
                "Twitter message 1",
                "Twitter message 2",
                "Twitter message 3"
                };

            return arr[random.Next(0, 2)];

        }

        private string GetLenta()
        {
            var arr = new List<string> {
                "Lenta message 1",
                "Lenta message 2",
                "Lenta message 3"
                };

            return arr[random.Next(0, 2)];
        }

        private string GetTv()
        {
            var arr = new List<string> {
                "Tv message 1",
                "Tv message 2",
                "Tv message 3"
                };

            return arr[random.Next(0, 2)];
        }
    }
}
