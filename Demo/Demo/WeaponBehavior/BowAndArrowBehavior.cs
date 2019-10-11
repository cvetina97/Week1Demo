using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.WeaponBehavior
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void Damage()
        {
            Console.WriteLine("I will destroy you with my bow and arrow!");
        }

        public void UseWeapon()
        {
            Console.WriteLine("I will use a bow and an arrow as a weapon!");
        }
    }
}
