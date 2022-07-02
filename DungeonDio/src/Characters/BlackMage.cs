using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDio.src.Characters
{
    public class BlackMage : Character
    {
        public BlackMage(string name, int level, string charType) : base(name, level, charType)
        {
            this.Name = name;
            this.Level = level;
            this.CharType = charType;
            hp = level * 7;
            mp = (level * 9) + 25;
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
                return this.Name + " Atacou com sua magia negra!";
            else
                return this.Name + " Atacou com uma magia simples";
        }

    }
}
