using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Decorator.Pizza
{
    class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza.Name + "with cheese", pizza)
        {
        }

        public override int GetCost()
        {
            return _pizza.GetCost() + 5;
        }
    }
}
