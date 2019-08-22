using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Factory.Games.Weapons;
using TestSOLID.Models.Paterns.Factory.Games.Move;

namespace TestSOLID.Models.Paterns.Factory.Games.Heroes
{
    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();

        public abstract Weapon CreateWeapon();
        
    }
}
