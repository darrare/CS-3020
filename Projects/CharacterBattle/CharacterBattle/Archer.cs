using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Archer : Character
    {
        public Archer(int position) : base(3, 15, 65, position, 1, 6)
        {
        }

        public override void Special(Character target)
        {
            if (Math.Abs(Position - target.Position) <= range * 2)
            {
                target.TakeDamage((int)(damagePerAttack * 2/3f));
            }
        }
    }
}
