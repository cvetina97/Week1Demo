using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.WeaponBehavior
{
    public class ToiletPaperBehavior : IWeaponBehavior
    {
        public void Damage()
        {
            Console.WriteLine("I will destroy you with the toilet paper!");
        }

        public void UseWeapon()
        {
            Console.WriteLine("I will use a toilet paper as a weapon !");
        }
    }
}
