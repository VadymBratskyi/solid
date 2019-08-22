using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Decorator.Pizza
{
    class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza) : base(pizza.Name + ", with tomatos", pizza)
        {
        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 3;
        }
    }
}
