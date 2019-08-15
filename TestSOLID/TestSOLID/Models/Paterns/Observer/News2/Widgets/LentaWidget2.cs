using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Observer.News2.Widgets
{
    public class LentaWidget2 : IWidget2
    {
        private string LentaMessage;                

        public void Display()
        {
            Console.WriteLine("Lenta: {0}", LentaMessage);
        }

        public void Update(object sender, NewsEventArgs2 args)
        {
            LentaMessage = args.Lenta;
            Display();
        }
    }
}
