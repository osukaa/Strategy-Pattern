using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy_Pattern.Behavior.fly;
using Strategy_Pattern.Behavior.quack;

namespace Strategy_Pattern.Client
{
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public Duck()
        {   
        }

        abstract public void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks can float, even decoys!");
        }

        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
