using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Cars.Parts
{
    class Wheels
    {
        public int Diametr { get; set; }

        public Wheels(int diametr) {
            Diametr = diametr;
            Console.WriteLine($"Wheels is {Diametr}r");
        }
    }
}
