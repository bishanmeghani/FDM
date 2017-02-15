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
        Repository repository;

        public void AddToCart(Book book)
        {
            repository.AddBook(book);
        }

        public List<Book> ViewAllBooks()
        {
            return books;
        }
    }
}
