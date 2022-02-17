using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame
{
    public class EnemyFactory
    {
        public static IEnemy RandomEnemy()
        {
            Random r = new Random();
            var rng = r.Next(10);
            if (rng < 4)
            {
                Console.WriteLine("A green goblin runs into the Arena. Prepare for battle. (hit enter)");
                Console.ReadLine();
                return new Goblin();
            }
            else if (rng < 7)
            {
                Console.WriteLine("A River Troll stumbles into the Arena. Prepare for battle. (hit enter)");
                Console.ReadLine();
                return new Troll();
            }
            else if (rng < 9)
            {
                Console.WriteLine("A Hill Giant fixes its gaze on you. Ready Yourself. (hit enter)");
                Console.ReadLine();
                return new Giant();
            }
            else
            {
                Console.WriteLine("A Blue Dragon soars into the Arena. Pray for mercy. (hit enter)");
                Console.ReadLine();
                return new Dragon();
            }
        }
    }
}
