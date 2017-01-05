using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            EffectiveWorker effective = new EffectiveWorker();
            LazyWorker lazy = new LazyWorker();
            RobotWorker robot = new RobotWorker();

            effective.Work();
            effective.Eat();

            lazy.Work();
            lazy.Eat();

            robot.Work();
            Console.ReadLine();
        }
    }
}
