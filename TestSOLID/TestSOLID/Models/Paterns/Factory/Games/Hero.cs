using System;
using System.Collections.Generic;
using System.Text;
using TestSOLID.Models.Paterns.Factory.Games.Heroes;
using TestSOLID.Models.Paterns.Factory.Games.Move;
using TestSOLID.Models.Paterns.Factory.Games.Weapons;

namespace TestSOLID.Models.Paterns.Factory.Games
{
    class Hero
    {
        private Weapon weapon;
        private Movement movement;
        
        public Hero(HeroFactory factory) {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }

        public void Run() {
            movement.Move();
        }

        public void Hit() {
            weapon.Hit();
        }
    }
}
