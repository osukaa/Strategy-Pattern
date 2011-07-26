using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy_Pattern.Behavior.fly;
using Strategy_Pattern.Behavior.quack;

namespace Strategy_Pattern.Client
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }

        public override void display()
        {
            Console.WriteLine("I'm a rubber duck");
        }
    }
}
