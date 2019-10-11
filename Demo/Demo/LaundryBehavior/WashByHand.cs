using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.LaundryBehavior
{
    public class WashByHand : ILaundryBehavior
    {
        public void Wash()
        {
            Console.WriteLine("I will wash by hand!");
        }
    }
}
