using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking.bookshop
{
    public class Stockchecker
    {
        Idatabasereader _dbreader;

        public Stockchecker(Idatabasereader dbreader)
        {
            _dbreader = dbreader;
        }

        public int numberinstock(string isbn)
        {
            int stock = _dbreader.readquantity("123");
            return stock;
        }
    }
}
