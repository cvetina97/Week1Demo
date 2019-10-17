using Demo.AttackBehavior;
using Demo.DefenceBehavior;
using Demo.LaundryBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class Smurfette : Character
    {
        public Smurfette(IDefenceBehavior defence, IAttackBehavior attack, ILaundryBehavior laundry) : base(defence, attack, laundry)
        {

        }

        public Smurfette(IDefenceBehavior defence) : base(defence)
        {

        }

        public Smurfette(IDefenceBehavior defence, ILaundryBehavior laundry) : base(defence, laundry)
        {

        }

        public Smurfette(IDefenceBehavior defence, IAttackBehavior attack) : base(defence, attack)
        {

        }

        public override void Fight()
        {
            Console.WriteLine("I am gonna kill you with beauty hahahah !");
        }
    }
}
