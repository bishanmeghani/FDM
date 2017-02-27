using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Repository
    {
        DatabaseLayer _context;

        public Repository(DatabaseLayer context)
        {
            _context = context;
        }

        public List<Book> GetAllBooks()
        {
            return _context.books.ToList();
        }

        public void AddBook(Book bookToAdd)
        {
            _context.books.Add(bookToAdd);
            _context.SaveChanges();
        }
    }
}
