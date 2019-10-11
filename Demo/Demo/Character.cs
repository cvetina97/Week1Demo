using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public abstract class Character
    {
        IWeaponBehavior weaponBehavior;
        ILaundryBehavior laundryBehavior;


        public Character(IWeaponBehavior wb)
        {
            this.weaponBehavior = wb;
        }

        public Character(IWeaponBehavior wb, ILaundryBehavior lb) : this(wb)
        {
            this.laundryBehavior = lb;
        }

        public abstract void Fight();

        public virtual void PerformUseWeapon()
        {
            this.weaponBehavior.UseWeapon();
        }

        public virtual void PerformDamage()
        {
            this.weaponBehavior.Damage();
        }

        public virtual void PerformLaundry()
        {
            this.laundryBehavior.Wash();
        }

        public void SetWeaponBehavior(IWeaponBehavior wb)
        {
            this.weaponBehavior = wb;
        }

        public void SetLaundryBehavior(ILaundryBehavior lb)
        {
            this.laundryBehavior = lb;
        }

        internal void PerformUseWeapon(string perform)
        {
            Console.WriteLine(perform);
        }


    }
}
