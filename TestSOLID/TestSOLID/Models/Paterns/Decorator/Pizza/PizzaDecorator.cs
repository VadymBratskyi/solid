using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Decorator.Pizza
{
    abstract class PizzaDecorator : Pizza
    {
        protected Pizza _pizza;

        public PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            _pizza = pizza;
        }
    }
}
