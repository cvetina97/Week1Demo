using Demo.AttackBehavior;
using Demo.DefenceBehavior;
using Demo.LaundryBehavior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class SmurfStorm : Character
    {
        public SmurfStorm(IDefenceBehavior defence, IAttackBehavior attack, ILaundryBehavior laundry) : base(defence, attack, laundry)
        {

        }

        public SmurfStorm(IDefenceBehavior defence) : base(defence)
        {

        }

        public SmurfStorm(IDefenceBehavior defence, ILaundryBehavior laundry) : base(defence, laundry)
        {

        }

        public SmurfStorm(IDefenceBehavior defence, IAttackBehavior attack) : base(defence, attack)
        {

        }

        public override void Fight()
        {
            Console.WriteLine("I will eliminate you with smurf storm !");
        }
    }
}
