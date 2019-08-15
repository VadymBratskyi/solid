using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Observer.News.Widgets;
using TestSOLID.Models.Paterns.Observer.News2.Widgets;

namespace TestSOLID.Models.Paterns.Observer.News2
{
    public class NewsEventArgs2 {

        public string Twitter { get; set; }
        public string Lenta { get; set; }
        public string Tv { get; set; }

        public NewsEventArgs2(string twitter, string lenta, string tv) {
            Twitter = twitter;
            Lenta = lenta;
            Tv = tv;
        }
    }

    public delegate void NewsChangedEventHandler(object sender, NewsEventArgs2 args);
    
    public class NewsAggregator2 : ISubjectNews2
    {
        private static Random random;

        public NewsAggregator2() {
            random = new Random();
        }

        public event NewsChangedEventHandler NewsChange;

        private void NewNewsAvailable() {

            var twitter = GetTwitter();
            var lenta = GetLenta();
            var tv = GetTv();

            if (NewsChange != null) {
                NewsChange(this, new NewsEventArgs2(twitter, lenta, tv));
            }


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

        public void RegisterObserver(IObserverNews2 observer)
        {
            NewsChange += observer.Update;
        }

        public void RemoveObserver(IObserverNews2 observer)
        {
            NewsChange -= observer.Update;
        }

        public void NotifyObserver()
        {
            NewNewsAvailable();
        }
    }
}
