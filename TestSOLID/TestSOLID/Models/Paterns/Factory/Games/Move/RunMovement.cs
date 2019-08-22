using System;
using System.Collections.Generic;
using System.Text;

namespace TestSOLID.Models.Paterns.Factory.Games.Move
{
    class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Run");
        }
    }
}
