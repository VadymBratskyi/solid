using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Cars.Parts
{
    class GasolineEngine : Engine
    {
        public GasolineEngine() {
            Console.WriteLine("Engine is gasoline");
        }
    }
}
