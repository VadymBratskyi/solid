using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Cars.Parts
{
    class DieselEngine : Engine
    {
        public DieselEngine() {
            Console.WriteLine("Engine is Diesel");
        }
    }
}
