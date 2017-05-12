using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Please select option A, B or C: ");
            input = Console.ReadLine();
            if (input == "A")
            {
                Console.WriteLine("You selected A");
            }
            else if (input == "B")
            {
                Console.WriteLine("You selected B");
            }
            else if (input == "C")
            {
                Console.WriteLine("You selected C");
            }
            else
            {
                Console.WriteLine("Invalid option");
            }
            Console.ReadLine();
        }
    }
}
