using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Factory.Cars.Parts;

namespace TestSOLID.Models.Paterns.Factory.Cars
{
    abstract class Car
    {
        protected string Name { get; set; }
        protected string Model { get; set; }
        protected Engine Engine { get; set; }
        protected Paint PaintColor { get; set; }
        protected Wheels Wheels { get; set; }
        protected string Body { get; set; }
        public Car(string name, string model) {
            Name = name;
            Model = model;
            Body = "sedan";
        }
        public abstract void Configuration();      

    }
}
