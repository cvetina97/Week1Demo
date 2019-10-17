using Demo.AttackBehavior;
using Demo.DefenceBehavior;
using Demo.LaundryBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class Queen : Character
    {
        public Queen(IDefenceBehavior defence, IAttackBehavior attack, ILaundryBehavior laundry) : base(defence, attack, laundry)
        {

        }

        public Queen(IDefenceBehavior defence) : base(defence)
        {

        }

        public Queen(IDefenceBehavior defence, ILaundryBehavior laundry) : base(defence, laundry)
        {

        }

        public Queen(IDefenceBehavior defence, IAttackBehavior attack) : base(defence, attack)
        {

        }
        public override void Fight()
        {
            Console.WriteLine("I'm leaving !");
        }
    }
}
