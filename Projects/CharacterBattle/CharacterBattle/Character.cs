using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBattle
{
    abstract class Character
    {
        protected int moveSpeed;
        protected int damagePerAttack;
        protected int range;
        public int Health { get; private set; }
        public int Position { get; private set; }
        public int Priority { get; private set; }

        public Character(int moveSpeed, int damagePerAttack, int health, int position, int priority, int range)
        {
            this.moveSpeed = moveSpeed;
            this.damagePerAttack = damagePerAttack;
            Health = health;
            Position = position;
            Priority = priority;
        }

        public void TakeDamage(int amount)
        {
            Health -= amount;
        }

        public bool Move(int distance)
        {
            if (Math.Abs(distance) > moveSpeed)
            {
                return false;
            }
            if (Position + distance >= 1 && Position + distance <= 50)
            {
                Position += distance;
            }
            else if (Position + distance > 50)
            {
                Position = 50;
            }
            else if (Position + distance < 1)
            {
                Position = 1;
            }
            return true;
        }

        public void Attack(Character target)
        {
            if (Math.Abs(Position - target.Position) <= range)
            {
                target.TakeDamage(damagePerAttack);
            }
        }

        public abstract void Special(Character target);
    }
}
