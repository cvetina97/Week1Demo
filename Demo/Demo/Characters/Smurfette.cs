using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class Smurfette : Character
    {
        public Smurfette(IWeaponBehavior wb) : base(wb)
        {

        }

        public Smurfette(IWeaponBehavior wb, ILaundryBehavior lb) : base(wb, lb)
        {

        }

        public override void Fight()
        {
            Console.WriteLine("I am gonna kill you with beauty hahahah !");
        }
    }
}
