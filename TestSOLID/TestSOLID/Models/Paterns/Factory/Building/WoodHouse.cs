using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Building
{
    class WoodHouse : House
    {
        public WoodHouse() {
            Console.WriteLine("Деревянный дом построен");
        }
    }
}
