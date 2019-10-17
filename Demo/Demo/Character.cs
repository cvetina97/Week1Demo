using Demo.AttackBehavior;
using Demo.DefenceBehavior;
using Demo.LaundryBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public abstract class Character
    {
        IAttackBehavior attackBehavior;
        IDefenceBehavior defenceBehavior;
        ILaundryBehavior laundryBehavior;
        


        public Character(IDefenceBehavior defence)
        {
            defenceBehavior = defence;
        }

        public Character(IDefenceBehavior defence,ILaundryBehavior laundry)
        {
            defenceBehavior = defence;
            laundryBehavior = laundry;
        }

        public Character(IDefenceBehavior defence, IAttackBehavior attack) : this(defence)
        {
            attackBehavior = attack;
        }

        public Character(IDefenceBehavior defence, IAttackBehavior attack,ILaundryBehavior laundry) : this(defence,attack)
        {
            laundryBehavior = laundry;
        }

        public abstract void Fight();

        public virtual void PerformAttack()
        {
            attackBehavior.Attack();
        }

        public virtual void PerformDefence()
        {
            defenceBehavior.Defence();
        }

        public virtual void PerformWash()
        {
            laundryBehavior.Wash();
        }

        public void SetAttackBehavior(IAttackBehavior attack)
        {
            attackBehavior = attack;
        }

        public void SetDefenceBehavior(IDefenceBehavior defence)
        {
            defenceBehavior = defence;
        }

        public void SetLaundryBehavior(ILaundryBehavior laundry)
        {
            laundryBehavior = laundry;
        }

        internal void PerformAttack(string attack)
        {
            Console.WriteLine(attack);
        }


    }
}
