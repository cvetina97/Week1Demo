using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class King : Character
    {

        public King(IWeaponBehavior wb) : base(wb)
        {

        }

        public King(IWeaponBehavior wb,ILaundryBehavior lb) : base(wb,lb)
        {

        }

        public override void Fight()
        {
            Console.WriteLine("Hayah");
        }
    }
}
