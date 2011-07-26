using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_Pattern.Behavior.fly
{
    public class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
