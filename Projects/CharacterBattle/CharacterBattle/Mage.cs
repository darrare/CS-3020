using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Mage : Character
    {
        public Mage(int position) : base(1, 20, 50, position, 2, 6)
        {

        }

        public override string GetSpecialDescription()
        {
            return "("+range / 2+" range attack that knocks the opponent away 4 units and deals "+damagePerAttack / 2+" damage)";
        }

        public override string Special(Character target)
        {
            if (Math.Abs(Position - target.Position) <= range / 2)
            {
                target.TakeDamage(damagePerAttack / 2);
                if (Position > target.Position)
                {
                    target.Move(-4, true);
                }
                else
                {
                    target.Move(4, true);
                }
                return "Successful knockback on opponent!";
            }
            return "Opponent out of range, unable to special.";
        }
    }
}
