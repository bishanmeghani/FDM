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
        SignOffDBModel context;

        public BookLogic(SignOffDBModel _context)
        {
            context = _context;
            repository = new Repository(_context);
        }

        public virtual void AddToCart(Book book)
        {
            try
            {
                repository.AddBook(book);
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }

        public virtual List<Book> ViewAllBooks()
        {
            try
            {
                return books;
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
    }
}
