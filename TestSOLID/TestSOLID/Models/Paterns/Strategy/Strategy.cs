using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.OpenClose.Strategy
{
    abstract class Strategy
    {
        public void ExecuteAlgorihtm() {
            Algorithm();
        }

        public abstract void Algorithm();
    }
}
