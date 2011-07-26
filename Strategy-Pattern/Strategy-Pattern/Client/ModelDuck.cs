using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy_Pattern.Behavior.fly;
using Strategy_Pattern.Behavior.quack;

namespace Strategy_Pattern.Client
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
