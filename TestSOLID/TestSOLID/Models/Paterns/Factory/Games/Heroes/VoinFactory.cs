using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Factory.Games.Move;
using TestSOLID.Models.Paterns.Factory.Games.Weapons;

namespace TestSOLID.Models.Paterns.Factory.Games.Heroes
{
    class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}
