using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.SOLID.OpenClose
{
    abstract class MealBase
    {
        public void Make() {
            Prepare();
            Cook();
            FinalSteps();
        }

        protected abstract void Prepare();
        protected abstract void Cook();
        protected abstract void FinalSteps();
    }
}
