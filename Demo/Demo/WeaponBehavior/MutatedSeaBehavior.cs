using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.WeaponBehavior
{
    public class MutatedSeaBehavior : IWeaponBehavior
    {
        public void Damage()
        {
            Console.WriteLine("I will destroy you with the Mutated sea!");
        }

        public void UseWeapon()
        {
            Console.WriteLine("I will use the Mutated sea as a weapon!");
        }
    }
}
