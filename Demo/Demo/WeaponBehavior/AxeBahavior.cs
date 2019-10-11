using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.WeaponBehavior
{
    public class AxeBahavior : IWeaponBehavior
    {
        public void Damage()
        {
            Console.WriteLine("I will destroy you with my Axe!");
        }

        public void UseWeapon()
        {
            Console.WriteLine("I will use an Axe as a weapon!");
        }
    }
}
