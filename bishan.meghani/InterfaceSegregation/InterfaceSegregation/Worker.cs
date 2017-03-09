using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregation
{
    public interface Worker
    {
        void Work();
    }

    public interface Eater
    {
        void Eat();
    }

    //instead of:
    //public interface WorkerEater
    //{
    //    void Work();
    //    void Eat();
    //}
    //to avoid abstract robot worker having to implement the Eat() function which it never uses.
    public class EffectiveWorker : Worker, Eater
    {
        public void Work()
        {
            Console.WriteLine("I work hard");
        }

        public void Eat()
        {
            Console.WriteLine("I eat enough");
        }
    }

    public class LazyWorker : Worker, Eater
    {
        public void Work()
        {
            Console.WriteLine("I don't work hard");
        }

        public void Eat()
        {
            Console.WriteLine("I eat too much");
        }
    }

    public class RobotWorker : Worker
    {
        public void Work()
        {
            Console.WriteLine("I work 24/7");
        }

            
    }
    
}
