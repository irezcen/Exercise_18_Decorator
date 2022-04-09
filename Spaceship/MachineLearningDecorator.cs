using System;
using System.Collections.Generic;
using System.Text;

namespace C8
{
    class MachineLearningDecorator:SpaceshipDecorator
    {
        public override string Type()
        {
            return extraSpaceship.Type() + "-AI";
        }
        public override int GetNextAttack()
        {
            Attack += 25;
            return base.GetNextAttack();
        }
        public MachineLearningDecorator(Spaceship.Spaceship spaceship) : base(spaceship)
        {

        }
    }
}
