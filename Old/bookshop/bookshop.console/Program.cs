using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookshop.console
{
    class Program
    {
        static void Main(string[] args)
        {
            book mybook = new book("Animal Farm", "George Orwell"); //second "book" is a constructor
            mybook.price = 10.00;
            mybook.isbn = "123ABC";
            mybook.numberofpages = -200;

            Console.WriteLine(mybook.title);
            Console.WriteLine(mybook.author);
            Console.WriteLine(mybook.numberofpages);
            Console.ReadLine();
        }
    }
}
