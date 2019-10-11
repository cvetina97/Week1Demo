using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.WeaponBehavior
{
    public class ToothPasteBehavior : IWeaponBehavior
    {
        public void Damage()
        {
            Console.WriteLine("I will destroy you with my toothpaste");
        }

        public void UseWeapon()
        {
            Console.WriteLine("I will use a toothpaste as a weapon!");
        }
    }
}
