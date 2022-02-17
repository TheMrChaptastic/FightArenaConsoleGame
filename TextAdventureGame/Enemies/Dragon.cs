using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame
{
    public class Dragon : IEnemy
    {
        public string Name { get; set; } = "Dragon";
        public int HP { get; set; } = 60;
        public int Attack { get; set; } = 20;
        public int Speed { get; set; } = 1;
        public int Gold { get; set; } = 30;
    }
}
