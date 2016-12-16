using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Catalogue
    {
        public List<Book> books { get; set; }
        public DatabaseReader myDBread { get; set; }
        public DatabaseWriter myDBwrite { get; set; }

        public List<Book> GetAllBooks()
        {
            books = myDBread.ReadDb();
            return books;
        }

        public Catalogue(DatabaseReader myDatabaseReader, DatabaseWriter myDatabaseWriter)
        {
            books = new List<Book>();
            myDBread = myDatabaseReader;
            myDBwrite = myDatabaseWriter;
        }

        public void AddBook(Book bookToAdd)
        {
            myDBwrite.WriteDatabase(bookToAdd);
        }
    }
}
