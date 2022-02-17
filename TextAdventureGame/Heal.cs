using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame
{
    public static class Heal
    {
        public static void HealPlayer(IProfession p)
        {
            while (p.Gold > 0 && p.HP < p.MaxHP)
            {
                p.Gold--;
                p.HP += 2;
                if (p.HP > p.MaxHP)
                {
                    p.HP = p.MaxHP;
                }
            }
        }
    }
}
