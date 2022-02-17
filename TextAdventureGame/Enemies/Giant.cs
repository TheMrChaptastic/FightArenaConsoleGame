using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame
{
    public class Giant : IEnemy
    {
        public string Name { get; set; } = "Giant";
        public int HP { get; set; } = 40;
        public int Attack { get; set; } = 12;
        public int Speed { get; set; } = 7;
        public int Gold { get; set; } = 12;
    }
}
