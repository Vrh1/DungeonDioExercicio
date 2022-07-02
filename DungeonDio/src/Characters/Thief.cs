using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDio.src.Characters
{
    public class Thief : Character
    {
        public Thief(string name, int level, string charType) : base (name, level, charType)
        {
            this.name = name;
            this.level = level;
            this.charType = charType;
            hp = level * 10;
            mp = (level * 3) + 20;
        }

        public string Attack(int bonus)
        {
            if (bonus >= 1)
                return this.name + " Atacou as costas de seu oponente!";
            else
                return this.name + " Atacou o inimigo com sua faca";
        }
    }
}
