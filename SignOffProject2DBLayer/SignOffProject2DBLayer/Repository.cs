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

        public virtual void AddBook(Book bookToAdd)
        {
            try
            {
                context.books.Add(bookToAdd);
                context.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public virtual List<Book> GetAllBooks()
        {
            try
            {
                return context.books.ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
