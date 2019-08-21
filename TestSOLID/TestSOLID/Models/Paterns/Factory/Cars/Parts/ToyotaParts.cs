using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Cars.Parts
{
    class ToyotaParts : PartsFactory
    {
        public override Engine SetEngine()
        {
            return new GasolineEngine();
        }

        public override Paint SetPaint(string color)
        {
            return new Paint(color);
        }

        public override Wheels SetWheels(int diametr)
        {
            return new Wheels(diametr);
        }
    }
}
