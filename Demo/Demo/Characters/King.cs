using Demo.AttackBehavior;
using Demo.DefenceBehavior;
using Demo.LaundryBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class King : Character
    {

        public King(IDefenceBehavior defence,IAttackBehavior attack,ILaundryBehavior laundry) : base(defence,attack,laundry)
        {

        }

        public King(IDefenceBehavior defence) : base(defence)
        {

        }

        public King(IDefenceBehavior defence, ILaundryBehavior laundry) : base(defence,laundry)
        {

        }

        public King(IDefenceBehavior defence, IAttackBehavior attack) : base(defence, attack)
        {

        }

        public override void Fight()
        {
            Console.WriteLine("Hayah");
        }
    }
}
