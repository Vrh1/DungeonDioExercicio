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
            this.name = name;
            this.level = level;
            this.charType = charType;
        }

        public string Attack(int bonus)
        {
            if (bonus == 1)
                return this.name + " canalizou o golpe de forma perfeita, golpe crítico aplicado!";
            else
                return this.name + " Atacou com seus punhos";
        }
    }
}
