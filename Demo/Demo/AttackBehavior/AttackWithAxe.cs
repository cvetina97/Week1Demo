using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.AttackBehavior
{
    public class AttackWithAxe : IAttackBehavior
    {

        public void Attack()
        {
            Console.WriteLine("My Axe will defeat you with 3 points of damage per hit ");
        }
    }
}
