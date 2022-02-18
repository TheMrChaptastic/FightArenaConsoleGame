using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TextAdventureGame
{
    public static class Fight
    {
        public static void StartFight(IProfession p, int roundWon)
        {
            var e = EnemyFactory.RandomEnemy(roundWon);
            var tick = 1;
            var rng = new Random();
            var dmg = 0;

            while(e.HP > 0 && p.HP > 0)
            {
                if (tick % e.Speed == 0)
                {
                    dmg = rng.Next(e.Attack);
                    p.HP -= dmg;
                    if (p.HP < 0) { p.HP = 0; }
                    Console.WriteLine($"The {e.Name} attacks you for {dmg} damage. HP Left: {p.HP}");
                    Thread.Sleep(200);
                }
                if (tick % p.Speed == 0)
                {
                    dmg = rng.Next(p.Attack);
                    Console.WriteLine($"You attack the {e.Name} for {dmg} damage.");
                    e.HP -= dmg;
                    Thread.Sleep(200);
                }
                tick++;
            }
            Console.WriteLine();
            if (p.HP > 0)
            {
                Console.WriteLine($"You defeated the {e.Name}.");
                var g = rng.Next(e.Gold);
                Console.WriteLine($"{e.Name} Dropped {g} Gold.");
                p.Gold += g;
            }
        }
    }
}
