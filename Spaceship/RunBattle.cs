using System;
using System.Collections.Generic;
using System.Text;

namespace C8.Spaceship
{
    class RunBattle
    {
        public static void Run()
        {
            // prepare spaceships
            var s1 = new ArmorDecorator(new SpaceshipLaser());
            var s2 = new ExtraCannonDecorator(new SpaceshipMachineLearning());
            var s3 = new NanobotsDecorator(new SpaceshipNanobots());
            var s4 = new MachineLearningDecorator(new SpaceshipExtraCannon());
            var s5 = new LaserDecorator(new SpaceshipLaser());
            List<Spaceship> tournamentList = new List<Spaceship>() { s1, s2, s3, s4, s5 };

            // run tournament
            for (int i = 0; i < tournamentList.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    // remember original statistics
                    int hp1 = tournamentList[i].Health;
                    int hp2 = tournamentList[j].Health;
                    int at1 = tournamentList[i].Attack;
                    int at2 = tournamentList[j].Attack;
                    // play this round
                    Console.WriteLine();
                    Console.WriteLine(tournamentList[i].Type() + " (" + tournamentList[i].Health + " HP) vs "
                            + tournamentList[j].Type() + " (" + tournamentList[j].Health + " HP)");
                    do
                    {
                        int attack1 = tournamentList[i].GetNextAttack();
                        int attack2 = tournamentList[j].GetNextAttack();
                        tournamentList[j].Health -= attack1;
                        tournamentList[i].Health -= attack2;
                        Console.WriteLine(tournamentList[i].Type() + " (" + tournamentList[i].Health + " HP) vs "
                            + tournamentList[j].Type() + " (" + tournamentList[j].Health + " HP)");
                    } while (tournamentList[j].Health > 0 && tournamentList[i].Health > 0);
                    if (tournamentList[j].Health > tournamentList[i].Health) Console.WriteLine("winner: " + tournamentList[j].Type());
                    else if (tournamentList[i].Health > tournamentList[j].Health) Console.WriteLine("winner: " + tournamentList[i].Type());
                    else Console.WriteLine("draw!");
                    // restore original statistics
                    tournamentList[i].Health = hp1;
                    tournamentList[j].Health = hp2;
                    tournamentList[i].Attack = at1;
                    tournamentList[j].Attack = at2;
                }
            }

        }
    }
}
