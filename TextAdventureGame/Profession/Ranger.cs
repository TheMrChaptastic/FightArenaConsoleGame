using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame
{
    public class Ranger : IProfession
    {
        public string Class { get; set; } = "Ranger";
        public int MaxHP { get; set; } = 40;
        public int HP { get; set; } = 40;
        public int Attack { get; set; } = 8;
        public int Speed { get; set; } = 3;
        public int Gold { get; set; } = 2;
    }
}
