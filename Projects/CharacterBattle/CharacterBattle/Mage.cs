using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Mage : Character
    {
        public Mage(int position) : base(1, 10, 50, position, 2, 6)
        {

        }

        public override void Special(Character target)
        {
            if (Math.Abs(Position - target.Position) <= range)
            {
                target.TakeDamage(damagePerAttack / 2);
                if (Position > target.Position)
                {
                    target.Move(-5);
                }
                else
                {
                    target.Move(5);
                }
            }
        }
    }
}
