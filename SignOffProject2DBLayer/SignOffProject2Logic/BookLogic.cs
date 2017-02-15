using SignOffProject2DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOffProject2Logic
{
    public interface IBookLogic
    {
        void AddToCart(Book book);
    }

    public class BookLogic : IBookLogic
    {
        List<Book> books;

        public void AddToCart(Book book)
        {
            books.Add(book);
        }
    }
}
