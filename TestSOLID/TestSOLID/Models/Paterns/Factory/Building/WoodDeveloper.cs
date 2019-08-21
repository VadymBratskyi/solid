using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Building
{
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name)
        {
        }

        public override House CreateHouse()
        {
            return new WoodHouse();
        }
    }
}
