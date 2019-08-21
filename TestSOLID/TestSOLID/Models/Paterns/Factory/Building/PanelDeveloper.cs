using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Building
{
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name)
        {
        }

        public override House CreateHouse()
        {
            return new PanelHouse();
        }
    }
}
