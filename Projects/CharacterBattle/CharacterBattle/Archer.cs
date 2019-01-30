using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    class Archer : Character
    {
        public Archer(int position) : base(3, 15, 65, position, 1, 3)
        {
        }

        public override string GetSpecialDescription()
        {
            return "(" +range * 4+" range attack that deals " +(int)(damagePerAttack * 2/3f)+ " damage)";
        }

        public override string Special(Character target)
        {
            if (Math.Abs(Position - target.Position) <= range * 4)
            {
                target.TakeDamage((int)(damagePerAttack * 2/3f));
                return "Opponent in range, dealt special damage!";
            }
            return "Opponent is out of range, special attack failed.";
        }
    }
}
