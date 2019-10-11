using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class Troll : Character
    {
        public Troll(IWeaponBehavior wb) : base(wb)
        {

        }

        public Troll(IWeaponBehavior wb, ILaundryBehavior lb) : base(wb, lb)
        {

        }

        public override void Fight()
        {
            Console.WriteLine("I'll eat you like a little mouse !");
        }
    }
}
