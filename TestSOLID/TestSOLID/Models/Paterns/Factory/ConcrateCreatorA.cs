using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory
{
    class ConcrateCreatorA : Creator
    {
        public override Product FactoruMathod()
        {
            return new ConcrateProductA();
        }
    }
}
