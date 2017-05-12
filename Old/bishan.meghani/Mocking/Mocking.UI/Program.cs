using Mocking.bookshop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            databasereader databasereader = new databasereader();
            Stockchecker stockchecker = new Stockchecker(databasereader);

            int stock = stockchecker.numberinstock("123");

            Console.WriteLine("Number in Stock: " + stock);
            Console.ReadLine();
        }
    }
}
