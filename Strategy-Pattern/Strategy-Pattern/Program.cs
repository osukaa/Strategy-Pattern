using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Strategy_Pattern.Tests;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //first test
            Console.WriteLine("Primera prueba MiniDuckSimulator.cs");
            MiniDuckSimulator mDuckSim = new MiniDuckSimulator();
            mDuckSim.main();

            Console.WriteLine();
            Console.WriteLine();

            //second test, changing dynamically the behavior
            Console.WriteLine("Segunda prueba DuckSimulator.cs");
            DuckSimulator duckSim = new DuckSimulator();
            duckSim.main();

            Console.ReadKey(true);
        }
    }
}
