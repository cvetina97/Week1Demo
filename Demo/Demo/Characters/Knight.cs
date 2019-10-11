using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class Knight: Character
    {
        public Knight(IWeaponBehavior wb) : base(wb)
        {

        }

        public Knight(IWeaponBehavior wb, ILaundryBehavior lb) : base(wb, lb)
        {

        }

        public override void Fight()
        {
            Console.WriteLine("I am gonna kill you !");
        }
    }
}
