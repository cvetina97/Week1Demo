using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class Queen : Character
    {
        public Queen(IWeaponBehavior wb) : base(wb)
        {

        }

        public Queen(IWeaponBehavior wb, ILaundryBehavior lb) : base(wb, lb)
        {

        }
        public override void Fight()
        {
            Console.WriteLine("I'm leaving !");
        }
    }
}
