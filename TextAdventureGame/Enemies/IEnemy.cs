using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame
{
    public interface IEnemy
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }
        public int Gold { get; set; }
    }
}
