using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Games.Weapons
{
    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Beat by sword");
        }
    }
}
