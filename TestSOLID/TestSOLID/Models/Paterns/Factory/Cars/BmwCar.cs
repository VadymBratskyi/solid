using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Factory.Cars.Parts;

namespace TestSOLID.Models.Paterns.Factory.Cars
{
    class BmwCar : Car
    {
        private PartsFactory _factory { get; set; }

        public BmwCar(PartsFactory factory, string model) : base("BMW", model)
        {
            _factory = factory;
            Console.WriteLine($"BMW car model {model} is builded");
        }

        public override void Configuration()
        {
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Model {Model}");

            Engine = _factory.SetEngine();
            PaintColor = _factory.SetPaint("red");
            Wheels = _factory.SetWheels(17);

            Console.WriteLine($"Body {Body}");
        }
    }
}
