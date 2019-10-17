using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.AttackBehavior
{
    public class AttackWithSword : IAttackBehavior
    {

        public void Attack()
        {
            Console.WriteLine("My Sword will defeat you with 5 points of damage per hit ");
        }
    }
}
