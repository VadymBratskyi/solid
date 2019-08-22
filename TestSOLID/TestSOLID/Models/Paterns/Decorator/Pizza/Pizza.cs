using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Decorator.Pizza
{
    abstract class Pizza
    {
        public string Name { get; protected set; }
        public abstract int GetCost();

        public Pizza(string name) {
            Name = name;
        }

    }
}
