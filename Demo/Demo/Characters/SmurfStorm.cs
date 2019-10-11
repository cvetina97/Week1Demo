using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Models
{
    public class SmurfStorm : Character
    {
        public SmurfStorm(IWeaponBehavior wb) : base(wb)
        {

        }

        public SmurfStorm(IWeaponBehavior wb, ILaundryBehavior lb) : base(wb, lb)
        {

        }

        public override void Fight()
        {
            Console.WriteLine("I will eliminate you with smurf storm !");
        }
    }
}
