using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Games.Weapons
{
    class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Shooting from arbalet");
        }
    }
}
