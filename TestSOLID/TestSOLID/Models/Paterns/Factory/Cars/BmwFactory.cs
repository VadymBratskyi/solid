using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Factory.Cars.Parts;

namespace TestSOLID.Models.Paterns.Factory.Cars
{
    class BmwFactory : CarFactory
    {
        public BmwFactory(string name) : base(name)
        {
        }

        public override Car BuildCar(string model)
        {
            PartsFactory parts = new BmwParts();
            return new BmwCar(parts, model);
        }

        
    }
}
