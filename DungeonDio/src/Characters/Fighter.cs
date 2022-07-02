using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonDio.src.Characters
{
    public class Fighter : Character
    {
        public Fighter(string name, int level, string charType) : base(name, level, charType)
        {
            this.Name = name;
            this.Level = level;
            this.CharType = charType;
            hp = level * 12;
            mp = level + 20;
        }

        public string Attack(int bonus)
        {
            if (bonus == 1)
                return this.Name + " canalizou o golpe de forma perfeita, golpe crítico aplicado!";
            else
                return this.Name + " Atacou com seus punhos";
        }
    }
}
