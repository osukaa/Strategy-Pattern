using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy_Pattern.Behavior.quack
{
    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
