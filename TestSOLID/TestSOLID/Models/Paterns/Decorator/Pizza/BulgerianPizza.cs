using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Decorator.Pizza
{
    class BulgerianPizza : Pizza
    {
        public BulgerianPizza() : base("Bulgerian pizza")
        {
        }

        public override int GetCost()
        {
            return 8;
        }
    }
}
