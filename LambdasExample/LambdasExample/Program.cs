using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the exact same thing:
            CheckValue(5);

            //as this
            Func<int, bool> example = x => x + 5 == 10;
            example.Invoke(5);

            LinqExamples();
            Console.ReadLine();
        }

        static bool CheckValue(int Value)
        {
            return Value + 5 == 10;
        }

        static void LinqExamples()
        {
            List<int> numbers = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            IEnumerable<int> evenNumbers = numbers.Where<int>(x => x % 2 == 0);
            foreach (var evenNumber in evenNumbers)
	        {
                Console.WriteLine(evenNumber);
            }

            IEnumerable<int> distinct = numbers.Distinct<int>();
            foreach (var distinctnumber in distinct)
            {
                Console.WriteLine(distinctnumber);
            }

            int firstFour = numbers.FirstOrDefault<int>(x => x == 4);

            int lastFour = numbers.LastOrDefault<int>(x => x == 4);

            int singleFour = numbers.SingleOrDefault<int>(x => x == 4);

            IEnumerable<int> firstFive = numbers.Take<int>(5);

            List<Book> book = new List<Book>()
            {
                new Book("title2", 40),
                new Book("title1", 300),
                new Book("title3", 10),
            };

            IEnumerable<Book> orderedBooks = book.OrderBy(b => b.title);
        }
    }
}
