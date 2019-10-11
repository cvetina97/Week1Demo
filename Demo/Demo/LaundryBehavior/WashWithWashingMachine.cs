using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.LaundryBehavior
{
    public class WashWithWashingMachine : ILaundryBehavior
    {
        public void Wash()
        {
            Console.WriteLine("I will wash with washing machine hahha !");
        }
    }
}
