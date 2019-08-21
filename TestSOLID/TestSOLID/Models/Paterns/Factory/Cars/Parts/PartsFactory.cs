using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Cars.Parts
{
    abstract class PartsFactory
    {
        public abstract Engine SetEngine();
        public abstract Paint SetPaint(string color);
        public abstract Wheels SetWheels(int diametr);
    }
}
