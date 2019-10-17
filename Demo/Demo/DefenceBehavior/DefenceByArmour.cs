using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DefenceBehavior
{
    public class DefenceByArmour : IDefenceBehavior
    {

        public void Defence()
        {
            Console.WriteLine("I will protect myself with an Armour , but my health would be affected with 3 points per shot");
        }
    }
}
