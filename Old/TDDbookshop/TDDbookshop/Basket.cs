using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDbookshop
{
    public class Basket
    {
        public List<book> books{ get; set; }
        public Basket()
        {
            books = new List<book>();
        }

        public List<book> getBooksInBasket()
        {
            return books;
        }

        public void addBook(book bookToAdd)
        {
            books.Add(bookToAdd);
        }

    }
}
