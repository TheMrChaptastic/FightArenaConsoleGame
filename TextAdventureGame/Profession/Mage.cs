using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame
{
    public class Mage : IProfession
    {
        public string Class { get; set; } = "Mage";
        public int MaxHP { get; set; } = 30;
        public int HP { get; set; } = 30;
        public int Attack { get; set; } = 15;
        public int Armor { get; set; } = 0;
        public int Speed { get; set; } = 5;
        public int Gold { get; set; } = 6;
    }
}
