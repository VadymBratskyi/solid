using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.DependencyInversion
{
    class HtmlPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать в html");
        }
    }
}
