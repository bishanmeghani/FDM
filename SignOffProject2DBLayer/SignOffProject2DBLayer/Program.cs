using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOffProject2DBLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            SignOffDBModel context = new SignOffDBModel();
            Book newBook1 = new Book() { title = "Lord of the Rings", price = 3.50 };
            Book newBook2 = new Book() { title = "Oliver Twist", price = 2.50 };
            Book newBook3 = new Book() { title = "The Shining", price = 4.50 };

            Repository repo = new Repository(context);
            repo.AddBook(newBook1);
            repo.AddBook(newBook2);
            repo.AddBook(newBook3);

        }
    }
}
