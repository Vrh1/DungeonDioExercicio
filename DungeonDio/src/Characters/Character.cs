using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDio.src.Characters
{
    public class Character
    {
        public Character(string name, int level, string charType)
        {
            this.name = name;
            this.level = level;
            this.charType = charType;
        }

        public string name { get; set; }
        public int level { get; set; }
        public string charType { get; set; }

        public override string ToString()
        {
            return this.name + " " + this.level + " " + this.charType;
        }

        public virtual string Attack()
        {
            return "basic attack";
        }

    }
}
