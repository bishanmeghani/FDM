using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace LoggingDemo
{
    class Program
    {
        private static readonly ILog logger = LogManager.GetLogger("Program.cs");
        static void Main(string[] args)
        {
            Divide();
        }

        private static void Divide()
        {
            try
            {
                int num1 = 10;
                int num2 = 0;
                int result = num1 / num2;
            }
            catch (DivideByZeroException ex)
            {
                logger.Error(ex.Message); // can do logger.Fatal(ex.Message);
                Console.WriteLine("Divided by zero");
            }
        }
    }
}
