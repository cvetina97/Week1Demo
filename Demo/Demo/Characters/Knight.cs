using Demo.AttackBehavior;
using Demo.DefenceBehavior;
using Demo.LaundryBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class Knight: Character
    {
        public Knight(IDefenceBehavior defence, IAttackBehavior attack, ILaundryBehavior laundry) : base(defence, attack, laundry)
        {

        }

        public Knight(IDefenceBehavior defence) : base(defence)
        {

        }

        public Knight(IDefenceBehavior defence, ILaundryBehavior laundry) : base(defence, laundry)
        {

        }

        public Knight(IDefenceBehavior defence, IAttackBehavior attack) : base(defence, attack)
        {

        }

        public override void Fight()
        {
            Console.WriteLine("I am gonna kill you !");
        }
    }
}
