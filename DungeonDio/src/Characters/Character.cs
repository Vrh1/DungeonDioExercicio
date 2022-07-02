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
            this.Name = name;
            this.Level = level;
            this.CharType = charType;
        }

        public string Name { get; set; }
        public int Level { get; set; }
        public string CharType { get; set; }
        public int hp;
        public int mp;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.CharType;
        }

        public virtual string Attack()
        {
            return "basic attack";
        }

    }
}
