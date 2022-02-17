using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TextAdventureGame
{
    public static class Fight
    {
        public static void StartFight(IProfession p)
        {
            var e = EnemyFactory.RandomEnemy();
            var turn = 1;
            var rng = new Random();
            var dmg = 0;

            while(e.HP > 0 && p.HP > 0)
            {
                if (turn % 2 != 0)
                {
                    if (p.Speed > e.Speed)
                    {
                        dmg = rng.Next(p.Attack);
                        Console.WriteLine($"You attack the {e.Name} for {dmg} damage.");
                        e.HP -= dmg;
                    }
                    else
                    {
                        dmg = rng.Next(e.Attack);
                        p.HP -= dmg;
                        if (p.HP < 0) { p.HP = 0; }
                        Console.WriteLine($"The {e.Name} attacks you for {dmg} damage. HP Left: {p.HP}");
                    }
                }
                else
                {
                    if (p.Speed > e.Speed)
                    {
                        dmg = rng.Next(e.Attack);
                        p.HP -= dmg;
                        if (p.HP < 0) { p.HP = 0; }
                        Console.WriteLine($"The {e.Name} attacks you for {dmg} damage. HP Left: {p.HP }");
                    }
                    else
                    {
                        dmg = rng.Next(p.Attack);
                        Console.WriteLine($"You attack the {e.Name} for {dmg} damage.");
                        e.HP -= dmg;
                    }
                }
                Thread.Sleep(200);
                turn++;
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
