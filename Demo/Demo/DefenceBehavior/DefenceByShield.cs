using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DefenceBehavior
{
    public class DefenceByShield : IDefenceBehavior
    {

        public void Defence()
        {
            Console.WriteLine("I will protect myself with Shield , but my health would be affected with 1 point per shot");
        }
    }
}
