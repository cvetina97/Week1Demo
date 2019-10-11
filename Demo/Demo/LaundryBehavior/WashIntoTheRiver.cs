using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.LaundryBehavior
{
    public class WashIntoTheRiver : ILaundryBehavior
    {
        public void Wash()
        {
            Console.WriteLine("I will wash into the river hahaha !");
        }
    }
}
