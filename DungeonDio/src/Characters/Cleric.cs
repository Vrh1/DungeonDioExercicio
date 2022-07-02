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
            this.Name = name;
            this.Level = level;
            this.CharType = charType;
            hp = level * 8;
            mp = (level * 7) + 15;
        }

        public string Attack(int bonus)
        {
            if (bonus != 0)
                return this.Name + " Curou os aliados com uma oração";
            else
                return this.Name + " Ninguem pode te ouvir";
        }

    }
}
