using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.WeaponBehavior
{
    public class PaperClipBehavior : IWeaponBehavior
    {
        public void Damage()
        {
            Console.WriteLine("I will destroy you with my paperclip !");
        }

        public void UseWeapon()
        {
            Console.WriteLine("I will use a paperclip as a weapon!");
        }
    }
}
