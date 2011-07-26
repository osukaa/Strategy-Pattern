using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy_Pattern.Behavior.fly;
using Strategy_Pattern.Behavior.quack;

namespace Strategy_Pattern.Client
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a decoy duck");
        }
    }
}
