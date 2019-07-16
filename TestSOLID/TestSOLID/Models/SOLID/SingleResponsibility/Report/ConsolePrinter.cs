using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.SingleResponsibility.Report
{
    class ConsolePrinter : IPrint
    {
        public void Print(string text)
        {
            Console.WriteLine($"Console prined: {text}");
        }
    }
}
