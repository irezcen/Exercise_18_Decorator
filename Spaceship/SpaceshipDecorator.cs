using System;
using System.Collections.Generic;
using System.Text;

namespace C8
{
    abstract class SpaceshipDecorator:Spaceship.Spaceship
    {
        protected Spaceship.Spaceship extraSpaceship = new Spaceship.Spaceship();
        public override int Health
        {
            get
            {
                return extraSpaceship.Health;
            }
            set
            {
                extraSpaceship.Health = value;
            }
        }
        public override int Attack
        {
            get
            {
                return extraSpaceship.Attack;
            }
            set
            {
                extraSpaceship.Attack = value;
            }
        }
        public override int GetNextAttack()
        {
            return extraSpaceship.GetNextAttack();
        }
        public SpaceshipDecorator(Spaceship.Spaceship spaceship)
        {
            extraSpaceship = spaceship;
        }
    }
}
