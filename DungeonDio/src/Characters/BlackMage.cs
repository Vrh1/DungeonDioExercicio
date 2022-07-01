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

        public override string Attack()
        {
            return this.name + " Atacou com sua magia negra!";
        }

    }
}
