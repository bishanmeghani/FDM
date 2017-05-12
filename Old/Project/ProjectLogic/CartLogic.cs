using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLogic
{

    public interface ICartLogic
    {
        void AddToCart(Book book);
    }

    public class CartLogic : ICartLogic
    {
        DatabaseLayer _context;
        Repository _repository;

        public CartLogic (DatabaseLayer context, Repository repository)
	    {
            _context = context;
            _repository = repository;
	    }

        public void AddToCart(Book bookAdd)
        {
            _repository.AddBook(bookAdd);
        }
    }
}
