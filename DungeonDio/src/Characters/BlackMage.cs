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
            this.name = name;
            this.level = level;
            this.charType = charType;
        }

        int dano ;

        public string Attack(int bonus)
        {
            if (bonus > 6)
                return this.name + " Atacou com sua magia negra!";
            else
                return this.name + " Atacou com uma magia simples";
        }

    }
}
