using Demo.AttackBehavior;
using Demo.DefenceBehavior;
using Demo.LaundryBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class Troll : Character
    {
        public Troll(IDefenceBehavior defence, IAttackBehavior attack, ILaundryBehavior laundry) : base(defence, attack, laundry)
        {

        }

        public Troll(IDefenceBehavior defence) : base(defence)
        {

        }

        public Troll(IDefenceBehavior defence, ILaundryBehavior laundry) : base(defence, laundry)
        {

        }

        public Troll(IDefenceBehavior defence, IAttackBehavior attack) : base(defence, attack)
        {

        }

        public override void Fight()
        {
            Console.WriteLine("I'll eat you like a little mouse !");
        }
    }
}
