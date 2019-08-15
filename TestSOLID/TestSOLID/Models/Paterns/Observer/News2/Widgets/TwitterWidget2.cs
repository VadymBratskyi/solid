using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.News2.Widgets
{
    public class TwitterWidget2 : IWidget2
    {
        private string TwitterMessage;
        
        public void Display()
        {
            Console.WriteLine("Twitter: {0}", TwitterMessage);
        }
        
        public void Update(object sender, NewsEventArgs2 args)
        {
            TwitterMessage = args.Twitter;
            Display();
        }
    }
}
