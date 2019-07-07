using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.OpenClose.Strategy
{
    abstract class Strategy
    {
        public void ExecuteAlgorihtm() {
            Algorithm();
        }

        public abstract void Algorithm();
    }
}
