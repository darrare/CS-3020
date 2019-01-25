using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Warrior : Character
    {
        public Warrior(int position) : base(2, 20, 75, position, 3, 1)
        {

        }

        public override void Special(Character target)
        {
            int distance = Math.Abs(Position - target.Position);
            if (distance == 6)
            {
                target.TakeDamage((int)(damagePerAttack * 1.5f));
            }

            if (distance > 6)
            {
                if (Position > target.Position)
                {
                    Move(-5);
                }
                else
                {
                    Move(5);
                }
            }
            else
            {
                if (Position > target.Position)
                {
                    Move(-distance + 1);
                }
                else
                {
                    Move(distance - 1);
                }
            }
        }
    }
}
