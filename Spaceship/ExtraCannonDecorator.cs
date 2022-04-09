using System;
using System.Collections.Generic;
using System.Text;

namespace C8
{
    class ExtraCannonDecorator:SpaceshipDecorator
    {
        public override string Type()
        {
            return extraSpaceship.Type() + "-cannon";
        }
        public override int GetNextAttack()
        {
            Random RNG = new Random();
            if (RNG.Next(2) == 0) return Attack + base.GetNextAttack();
            else return Attack + Attack + base.GetNextAttack();
        }
        public ExtraCannonDecorator(Spaceship.Spaceship spaceship) : base(spaceship)
        {

        }
    }
}
