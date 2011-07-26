using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy_Pattern.Client;
using Strategy_Pattern.Behavior.fly;
using Strategy_Pattern.Behavior.quack;

namespace Strategy_Pattern.Tests
{
    public class DuckSimulator
    {
        public void main()
        {
            Duck mallard = new MallardDuck();
            mallard.display();
            mallard.performQuack();
            mallard.performFly();

            // otro pato

            Duck model = new ModelDuck();
            model.display();
            model.performQuack();
            model.performFly();
            //cambio de vuelo
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
    }
}
