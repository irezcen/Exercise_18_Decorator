using System;
using System.Collections.Generic;
using System.Text;

namespace C8
{
    class NanobotsDecorator:SpaceshipDecorator
    {
        public override string Type()
        {
            return extraSpaceship.Type() + "-nanobots";
        }
        public override int GetNextAttack()
        {
            Health += 50;
            return Attack + base.GetNextAttack();
        }
        public NanobotsDecorator(Spaceship.Spaceship spaceship) : base(spaceship)
        {

        }
    }
}
