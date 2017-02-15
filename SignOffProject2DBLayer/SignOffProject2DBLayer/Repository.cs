using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOffProject2DBLayer
{
    public class Repository
    {
        SignOffDBModel context;

        public Repository(SignOffDBModel _context)
        {
            context = _context;
        }

        public List<Book> GetAllBooks()
        {
            return context.books.ToList();
        }

        public void AddBook(Book bookToAdd)
        {
            context.books.Add(bookToAdd);
            context.SaveChanges();
        }
    }
}
