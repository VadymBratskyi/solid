using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.OpenClose.Strategy
{
    class ContextStrategy1 : IStrategy
    {
        public void Algorithm()
        {
            Console.WriteLine("Hello from Strategy 1");
        }
    }
}
