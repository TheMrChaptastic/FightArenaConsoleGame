using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame
{
    public interface IProfession
    {
        public string Class { get; set; }
        public int MaxHP { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }
        public int Gold { get; set; }
    }
}
