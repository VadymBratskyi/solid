using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory
{
    class ConcrateCreatorB : Creator
    {
        public override Product FactoruMathod()
        {
            return new ConcrateProductB();
        }
    }
}
