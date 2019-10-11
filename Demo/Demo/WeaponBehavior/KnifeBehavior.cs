using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.WeaponBehavior
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void Damage()
        {
            Console.WriteLine("I will destroy you with my knife!");
        }

        public void UseWeapon()
        {
            Console.WriteLine("I will use a knife as a weapon!");
        }
    }
}
