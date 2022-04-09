using System;
using System.Collections.Generic;
using System.Text;

namespace C8
{
    class LaserDecorator:SpaceshipDecorator
    {
        public override string Type()
        {
            return extraSpaceship.Type() + "-laser";
        }
        public override int GetNextAttack()
        {
            return base.GetNextAttack() + Attack;
        }
        public LaserDecorator(Spaceship.Spaceship spaceship) : base(spaceship)
        {
            Attack+=50;
        }
    }
}
