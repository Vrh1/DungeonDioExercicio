using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDio.src.Characters
{
    public class Cleric : Character
    {
        public Cleric(string name, int level, string charType) : base(name, level, charType)
        {
            this.name = name;
            this.level = level;
            this.charType = charType;
            hp = level * 8;
            mp = (level * 7) + 15;
        }

        public string Attack(int bonus)
        {
            if (bonus != 0)
                return this.name + " Curou os aliados com uma oração";
            else
                return this.name + " Ninguem pode te ouvir";
        }

    }
}
