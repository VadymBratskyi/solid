using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Factory.Cars.Parts;

namespace TestSOLID.Models.Paterns.Factory.Cars
{
    class ToyotaFactory : CarFactory
    {
        public ToyotaFactory(string name) : base(name)
        {
        }

        public override Car BuildCar(string model)
        {
            PartsFactory parts = new ToyotaParts();
            return new ToyotaCar(parts, model);
        }
    }
}
