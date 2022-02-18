using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame
{
    public class Troll : IEnemy
    {
        public string Name { get; set; } = "Troll";
        public int HP { get; set; } = 30;
        public int Attack { get; set; } = 10;
        public int Speed { get; set; } = 6;
        public int Gold { get; set; } = 6;
    }
}
