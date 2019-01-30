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

        public override string GetSpecialDescription()
        {
            return "(Leaps up to 8 units towards the target. If target is greater than 5 units away, but less than 9, deals "+(int)(damagePerAttack * 1.5f)+" damage)";
        }

        public override string Special(Character target)
        {
            string retVal = "";
            int distance = Math.Abs(Position - target.Position);
            if (distance > 5 && distance < 9)
            {
                target.TakeDamage((int)(damagePerAttack * 1.5f));
                retVal += "Opponent is greater than 5 units away, delt bonus damage!\n";
            }

            if (distance > 8)
            {
                if (Position > target.Position)
                {
                    Move(-8, true);
                }
                else
                {
                    Move(8, true);
                }
                retVal += "Opponent is more than 8 units away, moving closer by 8 units.";
            }
            else
            {
                if (Position > target.Position)
                {
                    Move(-distance + 1, true);
                }
                else
                {
                    Move(distance - 1, true);
                }
                retVal +=  "Opponent is within 8 units, moving to melee range.";
            }
            return retVal;
        }
    }
}
