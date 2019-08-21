using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Factory.Cars.Parts;

namespace TestSOLID.Models.Paterns.Factory.Cars
{
    abstract class CarFactory
    {
        public string Name { get; set; }

        public CarFactory(string name) {
            Name = name;
        }

        public abstract Car BuildCar(string model);
    }
}
