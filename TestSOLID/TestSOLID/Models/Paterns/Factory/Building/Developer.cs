using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Building
{
    abstract class Developer
    {
        public string Name { get; set; }
        public Developer(string name) {
            Name = name;
        }
        abstract public House CreateHouse();
    }
}
