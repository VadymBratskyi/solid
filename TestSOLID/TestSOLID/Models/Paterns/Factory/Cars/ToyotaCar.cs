using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Factory.Cars.Parts;

namespace TestSOLID.Models.Paterns.Factory.Cars
{
    class ToyotaCar : Car
    {
        private PartsFactory _factory { get; set; }

        public ToyotaCar(PartsFactory factory, string model) : base("Toyota", model)
        {
            _factory = factory;
            Console.WriteLine($"Toyota car model {model} is builded");
        }

        public override void Configuration()
        {
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Model {Model}");

            Engine = _factory.SetEngine();
            PaintColor = _factory.SetPaint("green");
            Wheels = _factory.SetWheels(16);

            Console.WriteLine($"Body {Body}");
        }
    }
}
