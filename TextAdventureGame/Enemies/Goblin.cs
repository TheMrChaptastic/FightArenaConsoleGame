using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame
{
    public class Goblin : IEnemy
    {
        public string Name { get; set; } = "Goblin";
        public int HP { get; set; } = 20;
        public int Attack { get; set; } = 5;
        public int Speed { get; set; } = 3;
        public int Gold { get; set; } = 3;
    }
}
