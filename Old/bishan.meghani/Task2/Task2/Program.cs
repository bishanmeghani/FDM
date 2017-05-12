using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzRunner runner = new FizzBuzzRunner();
            runner.FizzBuzz(70);
            Console.ReadLine();
        }
    }
}
