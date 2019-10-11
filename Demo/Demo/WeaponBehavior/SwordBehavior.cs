using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.WeaponBehavior
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void Damage()
        {
            Console.WriteLine("I will destroy you with my sword!");
        }

        public void UseWeapon()
        {
            Console.WriteLine("I will use a sword as a weapon!");
        }
    }
}
