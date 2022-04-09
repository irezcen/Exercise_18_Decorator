using System;
using System.Collections.Generic;
using System.Text;

namespace C8
{
    class ArmorDecorator:SpaceshipDecorator
    {
        public override string Type()
        {
            return extraSpaceship.Type() + "-armor";
        }
        public override int GetNextAttack()
        {
            return base.GetNextAttack() + Attack;
        }
        public ArmorDecorator(Spaceship.Spaceship spaceship) : base(spaceship)
        {
            Health += 150;
        }
    }
}
