using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Decorator.Pizza
{
    class ItalianPizza : Pizza
    {
        public ItalianPizza() : base("Italian pizza")
        {
        }

        public override int GetCost()
        {
            return 10;
        }
    }
}
