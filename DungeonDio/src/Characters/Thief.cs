using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDio.src.Characters
{
    internal class Thief : Character
    {
        public Thief(string name, int level, string charType) : base (name, level, charType)
        {
            this.name = name;
            this.level = level;
            this.charType = charType;
        }

        public override string Attack()
        {
            return this.name + " Atacou com suas facas";
        }
    }
}
