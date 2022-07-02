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
            this.Name = name;
            this.Level = level;
            this.CharType = charType;
            hp = level * 10;
            mp = (level * 3) + 20;
        }

        public string Attack(int bonus)
        {
            if (bonus >= 1)
                return this.Name + " Atacou as costas de seu oponente!";
            else
                return this.Name + " Atacou o inimigo com sua faca";
        }
    }
}
