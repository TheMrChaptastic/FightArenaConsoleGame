using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame
{
    public class Warrior : IProfession
    {
        public string Class { get; set; } = "Warrior";
        public int MaxHP { get; set; } = 50;
        public int HP { get; set; } = 50;
        public int Attack { get; set; } = 10;
        public int Speed { get; set; } = 5;
        public int Gold { get; set; } = 4;
    }
}
