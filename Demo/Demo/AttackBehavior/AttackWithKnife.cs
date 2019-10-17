using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.AttackBehavior
{
    public class AttackWithKnife : IAttackBehavior
    {

        public void Attack()
        {
            Console.WriteLine("My Knife will defeat you with 2 points of damage per hit");
        }
    }
}
