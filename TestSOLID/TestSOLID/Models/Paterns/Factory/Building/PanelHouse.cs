using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Building
{
    class PanelHouse : House
    {
        public PanelHouse() {
            Console.WriteLine("Панельный дом построен");
        }
    }
}
