using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Cars.Parts
{
    class Paint
    {
        public string Color { get; set; }
        public Paint(string color) {
            Color = color;
            Console.WriteLine($"Paint is {Color}");
        }
    }
}
