using System;
using System.Collections.Generic;
using System.Text;

namespace C8.Spaceship
{
    class SpaceshipLaser : Spaceship
    {
        // spaceship with extra laser strength - more attack damage
        public SpaceshipLaser() : base()
        {
            Attack += 50;
        }
        public override string Type()
        {
            return "spaceship-laser";
        }

    }
}
