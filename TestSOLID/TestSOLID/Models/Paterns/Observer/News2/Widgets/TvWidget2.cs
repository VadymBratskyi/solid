using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.News2.Widgets
{
    public class TvWidget2 : IWidget2
    {
        private string TvMessage;              

        public void Display()
        {
            Console.WriteLine("Tv: {0}", TvMessage);
        }

        public void Update(object sender, NewsEventArgs2 args)
        {
            TvMessage = args.Tv;
            Display();
        }
    }
}
