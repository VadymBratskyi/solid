using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.OpenClose.Strategy
{
    class Context
    {
        IStrategy Strategy { get; set; }

        public Context(IStrategy strategy) {
            Strategy = strategy;
        }

        public void ExecuteAlgorihtm() {
            Strategy.Algorithm();
        }
    }
}
